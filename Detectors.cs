namespace C__Practice;

public class Detectors
{

    public static string detectHand(List<Card> hand)
    {
        // is it a pair?
        var faceCounts = countFaces(hand);
        foreach(var faceAndCount in faceCounts) {
            var face = faceAndCount.Key;
            var count = faceAndCount.Value;

            if (count == 2)
            {
                return $"Pair: {face}";
            }
            
            if (count == 3)
            {
                return $"Three of a kind: {face}";
            }

            if (count == 4)
            {
                return $"Four of a kind: {face}";
            }
        }


        // so its a HighCard
        var highCard = hand.OrderByDescending(card => card.face).First();

        return $"HighCard: {highCard.face} {highCard.suit}";
    }



    public static Dictionary<CardFace, int> countFaces(List<Card> hand) {

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

        foreach (var card in hand){
            facesCount[card.face]++;
        }

        return facesCount;
    }
}