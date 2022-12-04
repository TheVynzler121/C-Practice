// "4D 3H 2S TD QC" -> "high card: queen clubs"
// "4D 4H 2S TD QC" -> "pair of fours"
// "4D 4H 4S TD QC" -> "three of a kind of fours"
// faces (2-9, T, J, Q, K, A)
// suits  D - diamonds  S - spades  C - clubs  H - hearts

namespace C__Practice;

public enum CardFace
{
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
    Ace = 14,
}

public class PokerKata
{
    public static CardFace extractFace(string cardString) {
        var charToCardFace = new Dictionary<char, CardFace> {
            {'2', CardFace.Two},
            {'3', CardFace.Three},
            {'4', CardFace.Four},
            {'5', CardFace.Five},
            {'6', CardFace.Six},
            {'7', CardFace.Seven},
            {'8', CardFace.Eight},
            {'9', CardFace.Nine},
            {'T', CardFace.Ten},
            {'J', CardFace.Jack},
            {'Q', CardFace.Queen},
            {'K', CardFace.King},
            {'A', CardFace.Ace},
        };

        return charToCardFace[cardString[0]];
    }

}