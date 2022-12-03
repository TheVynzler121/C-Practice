//     // 4D 3H 2S TD QC - high card: queen clubs
//     // 4D 4H 2S TD QC - pair of fours
//     // 4D 4H 4S TD QC - three of a kind of fours
//faces (2-9, T, J, Q, K)
//suits // D - diamonds // S - spades // C - clubs // H - hearts

namespace C__Practice;

public enum Suit // enum = a list of numbers with names
{
    Hearts,
    Spades,
    Diamonds,
    Clubs,
}

public class Card  // Template for a new card // Combines two values into one class
{
    public Suit suit { get;set;}
    public int faceValue { get;set;}
}

public class PokerKata
{

    public static Card parseCard(string cardString) // returns Card with values filled in
    {
        var parsedFace = parseFace(cardString);
        var parsedSuit = parseSuit(cardString);
        var card = new Card() { faceValue = parsedFace, suit = parsedSuit };
        return card;
    }

    public static Suit parseSuit(string cardString)
    {
        var cardSuit = cardString[1];
        if (cardSuit == 'D' || cardSuit == 'd')
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