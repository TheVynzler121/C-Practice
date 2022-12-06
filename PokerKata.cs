// "4D 3H 2S TD QC" -> "high card: queen clubs"
// "4D 4H 2S TD QC" -> "pair of fours"
// "4D 4H 4S TD QC" -> "three of a kind of fours"
// faces (2-9, T, J, Q, K, A)
// suits  D - diamonds  S - spades  C - clubs  H - hearts

namespace C__Practice;

public enum CardFace // This is the enum list for the card faces, which is a list of numbers with names
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

public enum CardSuit
{
    Diamonds = 1,
    Spades = 2,
    Clubs = 3,
    Hearts = 4,
}

public class PokerKata
{
    public static Dictionary<string, int> countStrings(string[] keysToCount) {
        // histogram
        var counts = new Dictionary<string, int> { // storing the count of keys in the array that the foreach loop counted.
            {"A", 0},
            {"D", 0},
            {"C", 0},
        };

        foreach(var key in keysToCount) { // Counts the keys in the array keysToCount. It will go through this loop until it reaches the end of the given array.
            Console.WriteLine($"key is {key}");
            counts[key]++; // Adds 1 to the key Value in the counts Dictionary. i.e  It looks for an "A", finds the "A" in the given array, adds 1 for the value of "A" in the dictionary
        }

        return counts; // returns the number of times a Key was counted
    }

    public static CardFace extractFace(string cardString) {
        var charToCardFace = new Dictionary<char, CardFace> { // Makes the dictionary using a char as a key and a card name from the CardFace enum as the value
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
        var key = cardString[0]; // sets a var with the first position of the cardString index and turns it into a char from a string
        var value = charToCardFace[key]; // Searches the dictionary for the provided key and assigns the keys value to var value.
        return value; // Returns the value set above by var value
    }

    public static CardSuit extractSuit(string cardString){
        var charToCardSuit = new Dictionary<char, CardSuit> {
            {'D', CardSuit.Diamonds},
            {'S', CardSuit.Spades},
            {'C', CardSuit.Clubs},
            {'H', CardSuit.Hearts},
        };
        var key = cardString[1];
        var value = charToCardSuit[key];
        return value;
    }
}