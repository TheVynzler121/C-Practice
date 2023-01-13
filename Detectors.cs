namespace C__Practice;

public class DetectionResults {
    public bool IsMatch { get;set;}
    public int TieBreaker { get;set;}
}

public enum HandRank {
    HighCard,
    Pair,
    ThreeOfAKind,
    Straight,
    Flush,
    FullHouse,
    FourOfAKind,
    StraightFlush,
    RoyalFlush,
    
}

public class RankResults
{
    public HandRank Rank {get;set;}
    public int TieBreaker {get;set;}
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

    public static DetectionResults DetectStraightFlush(string inputHand)
    {
        var straight = DetectStraight(inputHand);
        var flush = DetectFlush(inputHand);

        if(straight.IsMatch && flush.IsMatch)
        {
            return new DetectionResults(){IsMatch = true, TieBreaker = straight.TieBreaker};
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public static bool DetectRoyalFlush(string inputHand)
    {
        var straightFlush = DetectStraightFlush(inputHand);

        return straightFlush.IsMatch && straightFlush.TieBreaker == 14;
    }


    public static RankResults DetectHand(string inputHand)
    {
        if(DetectRoyalFlush(inputHand))
        {
            return new RankResults(){Rank = HandRank.RoyalFlush, TieBreaker = 14};
        }

        var straightFlushResults = DetectStraightFlush(inputHand);
        if(straightFlushResults.IsMatch)
        {
            return new RankResults(){Rank = HandRank.StraightFlush, TieBreaker = straightFlushResults.TieBreaker};
        }

        var fourOfAKindResult = DetectFourOfAKind(inputHand);
        if(fourOfAKindResult.IsMatch)
        {
            return new RankResults(){Rank = HandRank.FourOfAKind, TieBreaker = fourOfAKindResult.TieBreaker};
        }

        var fullHouseResults = DetectFullHouse(inputHand);
        if(fullHouseResults.IsMatch)
        {           
            return new RankResults(){Rank = HandRank.FullHouse, TieBreaker = fullHouseResults.TieBreaker};
        }

        var flushResults = DetectFlush(inputHand);
        if(flushResults.IsMatch)
        {
            return new RankResults(){Rank = HandRank.Flush, TieBreaker = flushResults.TieBreaker};
        }

        var straightResults = DetectStraight(inputHand);
        if(straightResults.IsMatch)
        {
            return new RankResults(){Rank = HandRank.Straight, TieBreaker = straightResults.TieBreaker};
        }

        var threeOfAKindResults = DetectThreeOfAKind(inputHand);
        if(threeOfAKindResults.IsMatch)
        {
            return new RankResults(){Rank = HandRank.ThreeOfAKind, TieBreaker = threeOfAKindResults.TieBreaker};
        }
       
        var pairResults = DetectPair(inputHand);
        if(pairResults.IsMatch)
        {
            return new RankResults(){Rank = HandRank.Pair, TieBreaker = pairResults.TieBreaker};
        }
      
        return new RankResults(){Rank = HandRank.HighCard, TieBreaker = DetectHighCard(inputHand)};
    }

}