namespace C__Practice;

public class Detectors
{

    public static string detectHand(List<Card> hand)
    {
        var highCard = hand.OrderByDescending(card => card.face).First();

        return $"HighCard: {highCard.face} {highCard.suit}";
    }

}