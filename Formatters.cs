namespace C__Practice;

public class Formatters {
    //           parseCard             formatSuit/formatFace
    // string    ->        Card                 ->      string

    //           formatSuit/formatFace
    //  Card                 ->      string
    public static string printCard(Card card) {
        var cardSuit = formatSuit(card.Suit); //passes the Card's suit to formatSuit
        var cardFace = formatFace(card.Face); //passes the Card's face to formatFace
        var formatedCard = $"{cardFace} {cardSuit}"; //$"" makes a string //makes a string with the face and suit

        return formatedCard; // returns the string of face and suit
    }

    public static string formatFace(int inputInt) { //takes an Int and returns a string
        var x = new Dictionary<int, string> { // a collection of {keys, values}
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" },
            { 10, "Ten" },
            { 11, "Jack" },
            { 12, "Queen" },
            { 13, "King" },
            { 14, "Ace" }
        };

        return x[inputInt]; //return the value that matches the input int
    }

    public static string formatSuit((bool, bool) suitValue) { //takes a touple of (bool, bool) and returns a string
        if (suitValue == (true, true)) { //if the touple is true, true
            return "Hearts"; // early out return "hearts"
        }

        if (suitValue == (true, false)) {
            return "Spades";
        }

        if (suitValue == (false, true)) {
            return "Clubs";
        }

        if (suitValue == (false, false)) {
            return "Diamonds";
        }

        return "";
    }
}