namespace C__Practice;

public class Formatters {
    //           parseCard             formatSuit/formatFace
    // string    ->        Card                 ->      string

    //           formatSuit/formatFace
    //  Card                 ->      string
    public static string printCard(Card card) {
        var cardSuit = formatSuit(card.Suit);
        var cardFace = formatFace(card.Face);
        var formatedCard = $"{cardFace} {cardSuit}";

        return formatedCard;
    }

    public static string formatFace(int inputInt) {
        var x = new Dictionary<int, string> {
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

        return x[inputInt];
    }

    public static string formatSuit((bool, bool) suitValue) {
        if (suitValue == (true, true)) {
            return "Hearts";
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