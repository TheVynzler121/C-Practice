namespace C__Practice;

public class DetectionResults {
    public bool IsMatch { get;set;}
    public int TieBreaker { get;set;}
}


public class Detectors
{
    public static int DetectHighCard(string inputHand)
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
        return highCard.Face;
    }

    public static DetectionResults DetectPair(string inputHand)
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

    public static DetectionResults DetectThreeOfAKind(string inputHand)
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

    public static DetectionResults DetectFourOfAKind(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var value = counts[face];
            if(value == 4)
            {
                return new DetectionResults(){IsMatch = true, TieBreaker = face};
            }
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
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

    public static Dictionary<(bool, bool), int> CountSuit(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand);

        var counts = new Dictionary<(bool, bool), int>
        {
            {(true, true), 0},
            {(true, false), 0},
            {(false, true), 0},
            {(false, false), 0},
        };

        foreach (var card in hand)
        {
            counts[card.Suit]++;
        }
        return counts;
    }
    
    public static DetectionResults DetectFullHouse(string inputHand)
    {
        var pair = DetectPair(inputHand);
        var threeOfAKind = DetectThreeOfAKind(inputHand);

        if (pair.IsMatch && threeOfAKind.IsMatch)
        {
            return new DetectionResults(){IsMatch = true, TieBreaker = threeOfAKind.TieBreaker};
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public static DetectionResults DetectFlush(string inputHand)
    {
        var countedsuit = CountSuit(inputHand);
        
        foreach (var suitCount in countedsuit)
        {
            var suit = suitCount.Key;  // (bool,bool)
            var count = suitCount.Value; // int

            if(count == 5)
            {
                return new DetectionResults() {IsMatch = true, TieBreaker = DetectHighCard(inputHand)};
            }
        }
        return new DetectionResults() {IsMatch = false, TieBreaker = 0};
    }

    public static DetectionResults DetectStraight(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand).OrderBy(card => card.Face).ToList();

        var nextFace = hand[0].Face;
        foreach(var card in hand) {
            if (card.Face != nextFace)
            {
                return new DetectionResults(){IsMatch = false, TieBreaker = 0};
            }
            nextFace = card.Face + 1;
        }               
        return new DetectionResults(){IsMatch = true, TieBreaker = DetectHighCard(inputHand)};
    }

   //          parser                            Split 
   // raw data     ->    core logic / formatter    ->   core logic 


   // raw data     ->    core logic   ->   formatting

}