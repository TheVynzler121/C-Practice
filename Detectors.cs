namespace C__Practice;

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

    public static string DectectPair(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var value = counts[face];
            if(value == 2)
            {
                return $"Pair of : {Formatters.formatFace(face)}";
            }
        }
        return null;
    }

    public static string DectectThreeOfAKind(string inputHand)
    {
        var counts = CountFaces(inputHand).ToList();

        for(var face = 0; face < counts.Count; face++) 
        {
            var value = counts[face];
            if(value == 3)
            {
                return $"Three of a kind : {Formatters.formatFace(face)}";
            }
        }
        return null;
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
    
    
}