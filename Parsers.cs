// "4D 3H 2S TD QC" -> "high card: queen clubs"
// "4D 4H 2S TD QC" -> "pair of fours"
// "4D 4H 4S TD QC" -> "three of a kind of fours"
// faces (2-9, T, J, Q, K, A)
// suits  D - diamonds  S - spades  C - clubs  H - hearts

namespace C__Practice;

public class Parsers
{
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
        
        var firstLetter = inputString[0].ToString();

        if(faceToNumb.ContainsKey(firstLetter)) {
            return faceToNumb[firstLetter];
        } else {
            return Int32.Parse(firstLetter);
        }
    }
}