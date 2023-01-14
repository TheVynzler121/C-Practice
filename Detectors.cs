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
    // field / property
    public HandRank Rank {get;set;}
    public int TieBreaker {get;set;}
}


public class Detectors
{
    // field / property
    public IEnumerable<Card> hand;

    // contructor
    public Detectors(string inputHand)
    {
        hand = Parsers.parseHand(inputHand);
    }

    // (class) member function / methods
    public int DetectHighCard()
    {
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

    public DetectionResults DetectPair()
    {
        var counts = CountFaces().ToList();

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

    public DetectionResults DetectThreeOfAKind()
    {
        var counts = CountFaces().ToList();

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

    public DetectionResults DetectFourOfAKind()
    {
        var counts = CountFaces().ToList();

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
    
    public IEnumerable<int> CountFaces()
    {       
        var counts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (var card in hand)
        {
            counts[card.Face]++;
        }
        return counts;
    }

    public Dictionary<(bool, bool), int> CountSuit()
    {       
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
    
    public DetectionResults DetectFullHouse()
    {
        var pair = DetectPair();
        var threeOfAKind = DetectThreeOfAKind();

        if (pair.IsMatch && threeOfAKind.IsMatch)
        {
            return new DetectionResults(){IsMatch = true, TieBreaker = threeOfAKind.TieBreaker};
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public DetectionResults DetectFlush()
    {
        var countedsuit = CountSuit();
        
        foreach (var suitCount in countedsuit)
        {
            var suit = suitCount.Key;  // (bool,bool)
            var count = suitCount.Value; // int

            if(count == 5)
            {
                return new DetectionResults() {IsMatch = true, TieBreaker = DetectHighCard()};
            }
        }
        return new DetectionResults() {IsMatch = false, TieBreaker = 0};
    }

    public DetectionResults DetectStraight()
    {
        var orderedHand = hand.OrderBy(card => card.Face).ToList();

        var nextFace = orderedHand[0].Face;
        foreach(var card in orderedHand) {
            if (card.Face != nextFace)
            {
                return new DetectionResults(){IsMatch = false, TieBreaker = 0};
            }
            nextFace = card.Face + 1;
        }               
        return new DetectionResults(){IsMatch = true, TieBreaker = DetectHighCard()};
    }

    public DetectionResults DetectStraightFlush()
    {
        var straight = DetectStraight();
        var flush = DetectFlush();

        if(straight.IsMatch && flush.IsMatch)
        {
            return new DetectionResults(){IsMatch = true, TieBreaker = straight.TieBreaker};
        }
        return new DetectionResults(){IsMatch = false, TieBreaker = 0};
    }

    public bool DetectRoyalFlush()
    {
        var straightFlush = DetectStraightFlush();

        return straightFlush.IsMatch && straightFlush.TieBreaker == 14;
    }

    public RankResults DetectHand()
    {
        if(DetectRoyalFlush())
        {
            return new RankResults(){Rank = HandRank.RoyalFlush, TieBreaker = 14};
        }

        var detectors = new List<(Func<DetectionResults>, HandRank)>(){
            (DetectStraightFlush, HandRank.StraightFlush),
            (DetectFourOfAKind, HandRank.FourOfAKind),
            (DetectFullHouse, HandRank.FullHouse),
            (DetectFlush, HandRank.Flush),
            (DetectStraight, HandRank.Straight),
            (DetectThreeOfAKind, HandRank.ThreeOfAKind),
            (DetectPair, HandRank.Pair)
        };

        foreach(var detector in detectors)
        {
            var result = detector.Item1();
            if(result.IsMatch)
            {
                return new RankResults(){Rank = detector.Item2, TieBreaker = result.TieBreaker};
            }
        }
            
        return new RankResults(){Rank = HandRank.HighCard, TieBreaker = DetectHighCard()};
    }
}