// "4D 3H 2S TD QC" -> "high card: queen clubs"
// "4D 4H 2S TD QC" -> "pair of fours"
// "4D 4H 4S TD QC" -> "three of a kind of fours"
// faces (2-9, T, J, Q, K, A)
// suits  D - diamonds  S - spades  C - clubs  H - hearts


// ("4D 3H 2S TD QC", "4D 4H 2S TD QC") -> "Player 2 wins: Pair of Four"


// parseFace(string)  => int
// parseSuit(string) => (bool, bool)
// handSplitter(string)  => List<string>
// parseCard(string)  => Card
// parseHand(string) => List<Card>


namespace C__Practice;

public class Card
{
    public int Face { get; set; }
    public (bool, bool) Suit { get; set; }
}

public class Parsers
{

    // "3D"
    public static Card parseCard(string cardString)
    {
        var x = new Card()
        {
            Face = parseFace(cardString),
            Suit = parseSuit(cardString)
        };
        return x;
    }

    public static IEnumerable<Card> parseHand(string handString)
    {
        System.Threading.Thread.Sleep(1000);
        return handSplitter(handString).Select(parseCard);           
    }


    public static (bool, bool) parseSuit(string card)
    {
        if (card[1] == 'H')
        {
            return (true, true);
        }
        if (card[1] == 'S')
        {
            return (true, false);
        }
        if (card[1] == 'C')
        {
            return (false, true);
        }
        if (card[1] == 'D')
        {
            return (false, false);
        }
        return (false, false);
    }

    //       Split       ToList         
    // string => string[]  => List<string> 
    public static List<string> handSplitter(string inputString)
    {
        return inputString.Split(' ').ToList();
    }
    //      [0]     ToString  Int32.Parse 
    // "KD"  =>   'K' => "K"      =>      ??
    public static int parseFace(string inputString)
    {
        var faceToNumb = new Dictionary<string, int>()
        {
            {"T", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13},
            {"A", 14},
        };

        var faceString = inputString[0].ToString();

        if (faceToNumb.ContainsKey(faceString))
        {
            return faceToNumb[faceString];
        }
        else
        {
            return Int32.Parse(faceString);
        }
    }
}