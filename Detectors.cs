namespace C__Practice;

public class DetectionResults {
    public bool IsMatch { get;set;}
    public int TieBreaker { get;set;}
}

public class DetectionResultsSuit {
    public bool IsMatch { get;set;}
    public (bool, bool) TieBreaker { get;set;}
}

public class Detectors
{
    public static string DetectHighCard(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand);
        var highCard = hand.ToList()[0];

        foreach (var card in hand)
        {
            if (card.Face > highCard.Face)
            {
                highCard = card;
            }
        }
        return $"High card is : {Formatters.printCard(highCard)}";
    }

    public static DetectionResults DectectPair(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var count = counts[face];
            if(count == 2)
            {
                return new DetectionResults(){IsMatch = true, TieBreaker = face};
            }
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public static DetectionResults DectectThreeOfAKind(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var count = counts[face];
            if(count == 3)
            {
                return new DetectionResults(){IsMatch = true, TieBreaker = face};
            }
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public static string DectectFourOfAKind(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var value = counts[face];
            if(value == 4)
            {
                return $"Four of a kind : {Formatters.formatFace(face)}";
            }
        }
        return null;
    }
    
    public static IEnumerable<int> CountFaces(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand);

        var counts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (var card in hand)
        {
            counts[card.Face]++;
        }
        return counts;
    }
    
    public static DetectionResults DetectFullHouse(string inputHand)
    {
        var pair = DectectPair(inputHand);
        var threeOfAKind = DectectThreeOfAKind(inputHand);

        if (pair.IsMatch && threeOfAKind.IsMatch)
        {
            return new DetectionResults(){IsMatch = true, TieBreaker = threeOfAKind.TieBreaker};
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }
   //          parser                            Split 
   // raw data     ->    core logic / formatter    ->   core logic 


   // raw data     ->    core logic   ->   formatting

}