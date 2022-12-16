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

public class WarriorSet {
    public string name {get;set;} // "Worldbreaker"
    public int strBonus {get;set;} 
    public int dmgBonus {get; set;}
}

public class Player {
    public string playerName;
    public string PlayerClass {get;set;} // "Warrior", ...
    public int playerLevel;
    public int playerHp;
    public string playerTitle;
    public int armorClass;
    public string playerStr;
    public int strength;
    public string playerDex;
    public int dexterity;
    public string playerCon;
    public int consitution;
    public const string intelligenceDisplayName = "Intelligence";
    public int intelligence;
}

public class Helm {
    public string name {get; set;}
    public string rarity {get; set;}  // "Epic", "Common"
    public string armorClass {get; set;} // "Plate", "Mail", "Cloth"
    public int armorValue {get; set;}
    public WarriorSet set {get; set;}  // "Worldbreaker"
    public int levelReq {get; set;}
    public string mainStat;
    public int mainStatValue;
    public string secondStat;
    public int secStatValue;
    public string flavorText {get; set;}
}


public class Card {

    public CardFace face {get;set;} // public = everyone can access it. get; = everyone can get it. set; = everyone can set it.
    public CardSuit suit {get;set;}
}

public class Parsers
{


    // public static List<X> dummyFunc(string cardInput) {
        // remembered list

        // foreach(var cardString in splitCards) {
            // remembered list .Add(....)
        // }

        // return remembered list
    // }

    public static List<Card> parseCards(string cardInput)
    {
        var cards = new List<Card>();

        foreach(var cardString in cardInput.Split(' '))
        {
            cards.Add(parseCard(cardString));
        }
        return cards;
    }

    


    // when you "instantiate" a class, you have to call (one) if it's constructors
    // if it has none it will call the implicit constructor + default all properties, 
    // unless if you use the object intialization syntax
   public static Card parseCard(string cardInput){  
        return new Card {
            face = extractFace(cardInput),
            suit = extractSuit(cardInput),
        };
   }


    public static Dictionary<string, int> countStrings(string[] keysToCount) {

        // histogram
        var counts = new Dictionary<string, int> { // creates the dictionary there the foreach loop will store the counted values
            {"A", 0},
            {"D", 0},
            {"C", 0},
        };

        foreach(var key in keysToCount) { // Counts the keys in the array keysToCount. It will go through this loop until it reaches the end of the given array.
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
        return charToCardFace[cardString[0]]; // Searches the dictionary for the provided key and assigns the keys value to var value then Returns the value set above by var value
    }

    public static CardSuit extractSuit(string cardString){
        var charToCardSuit = new Dictionary<char, CardSuit> {
            {'D', CardSuit.Diamonds},
            {'S', CardSuit.Spades},
            {'C', CardSuit.Clubs},
            {'H', CardSuit.Hearts},
        };
        return charToCardSuit[cardString[1]];
    }
}