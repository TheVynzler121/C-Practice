namespace C__Practice;

public class PokerKata
{
	// faces (2-9, T, J, Q, K)
	// suits // D - diamonds // S - spades // C - clubs // H - hearts

    // 4D 3H 2S TD QC - high card: queen clubs
    // 4D 4H 2S TD QC - pair of fours
    // 4D 4H 4S TD QC - three of a kind of fours


    public static int parseFace(string cardString)
    {
        // "4D" -> '4' -> "4" -> 4
        return Int32.Parse(cardString[0].ToString());
    }
}