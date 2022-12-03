//     // 4D 3H 2S TD QC - high card: queen clubs
//     // 4D 4H 2S TD QC - pair of fours
//     // 4D 4H 4S TD QC - three of a kind of fours

namespace C__Practice;

public enum Suit
{
    Hearts,
    Spades,
    Diamonds,
    Clubs,
}

public class PokerKata
{
    //faces (2-9, T, J, Q, K)
    //suits // D - diamonds // S - spades // C - clubs // H - hearts

    public static Suit parseSuit(string cardString)
    {
        var cardSuit = cardString[1];
        if (cardSuit == 'D')
        {
            return Suit.Diamonds;
        }

        if (cardSuit == 'S')
        {
            return Suit.Spades;
        }

        if (cardSuit == 'C')
        {
            return Suit.Clubs;
        }

        if (cardSuit == 'H')
        {
            return Suit.Hearts;
        }

        throw new NotImplementedException();
    } 

    public static int parseFace(string cardString)
    {
        var cardFace = cardString[0];
        if (cardFace == 'T')
        {
            return 10;
        }

        if (cardFace == 'J')
        {
            return 11;
        }

        if (cardFace == 'Q')
        {
            return 12;
        }

        if (cardFace == 'K')
        {
            return 13;
        }

        if (cardFace == 'A')
        {
            return 14;
        }
        // else
        return Int32.Parse(cardFace.ToString());
    }
}