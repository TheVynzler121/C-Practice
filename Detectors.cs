namespace C__Practice;

public enum HandKind
{
    Pair = 1,
    ThreeOfAKind = 2,
    FourOfAKind = 3,
}

public class Detectors
{
    public static void printDictionary(Dictionary<HandKind, List<CardFace>> kindCounts) {
        Console.WriteLine("------- Dict Start { ");
        foreach (var keyAndValue in kindCounts)
        {
            Console.WriteLine($"Key: {keyAndValue.Key} Value: [");
            keyAndValue.Value.ForEach(x=>Console.Write(x));
            Console.WriteLine("]");
        }
        Console.WriteLine("} Dict End ----- ");
    }

    public static void printDictionary(Dictionary<CardFace, int> faceCounts) {
        Console.WriteLine("------- Dict Start { ");
        foreach (var keyAndValue in faceCounts)
        {
            Console.WriteLine($"Key: {keyAndValue.Key} Value: {keyAndValue.Value}");
        }
        Console.WriteLine("} Dict End ----- ");
    }

    public static string detectHand(List<Card> hand)
    {
        var faceCounts = countFaces(hand);
       // printDictionary(faceCounts);

        var handKindCounts = countHandKinds(faceCounts);
        //printDictionary(handKindCounts);

        var pairFaces = handKindCounts[HandKind.Pair];
        var threeOfAKindFaces = handKindCounts[HandKind.ThreeOfAKind];
        var fourOfAKindFaces = handKindCounts[HandKind.FourOfAKind];
        
        if (pairFaces.Count == 1 && threeOfAKindFaces.Count == 1)
        {
            return $"Full House: {threeOfAKindFaces[0]} {pairFaces[0]}";
        }
        
        if (pairFaces.Count == 1)
        {
            return $"Pair: {pairFaces[0]}";
        }

        if (threeOfAKindFaces.Count == 1)
        {
            return $"Three of a kind: {threeOfAKindFaces[0]}";
        }

        if (fourOfAKindFaces.Count == 1)
        {
            return $"Four of a kind: {fourOfAKindFaces[0]}";
        }


        // so its a HighCard
        var highCard = hand.OrderByDescending(card => card.face).First();

        return $"HighCard: {highCard.face} {highCard.suit}";
    }

    public static Dictionary<HandKind, List<CardFace>> countHandKinds(Dictionary<CardFace, int> faceCounts)
    {
        var handKind = new Dictionary<HandKind, List<CardFace>> {
            {HandKind.Pair , new List<CardFace>()},// [CardFace.Ten]
            {HandKind.ThreeOfAKind , new List<CardFace>()}, // [CardFace.King]
            {HandKind.FourOfAKind , new List<CardFace>()}, 
        };

        foreach (var faceAndCount in faceCounts)
        {
            var face = faceAndCount.Key;
            var count = faceAndCount.Value;
            switch (count)
            {
                case 2: handKind[HandKind.Pair].Add(face); break;
                case 3: handKind[HandKind.ThreeOfAKind].Add(face); break;
                case 4: handKind[HandKind.FourOfAKind].Add(face); break;
            }
        }

        return handKind;
    }

    public static Dictionary<CardFace, int> countFaces(List<Card> hand)
    {

        var facesCount = new Dictionary<CardFace, int> {
            { CardFace.Two , 0},
            { CardFace.Three , 0},
            { CardFace.Four , 0},
            { CardFace.Five , 0},
            { CardFace.Six , 0},
            { CardFace.Seven , 0},
            { CardFace.Eight , 0},
            { CardFace.Nine , 0},
            { CardFace.Ten , 0},
            { CardFace.Jack , 0},
            { CardFace.Queen , 0},
            { CardFace.King , 0},
            { CardFace.Ace , 0},
        };

        foreach (var card in hand)
        {
            facesCount[card.face]++;
        }

        return facesCount;
    }
}