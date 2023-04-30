// "4D 3H 2S TD QC" -> "high card: queen clubs"
// "4D 4H 2S TD QC" -> "pair of fours"
// "4D 4H 4S TD QC" -> "three of a kind of fours"
// faces (2-9, T, J, Q, K, A)
// suits  D - diamonds  S - spades  C - clubs  H - hearts


// ("4D 3H 2S TD QC", "4D 4H 2S TD QC") -> "Player 2 wins: Pair of Four"
// ("4D 3H 2S TD QC", "4D KH 2S TD QC") -> "Player 2 wins: High Card King Hearts"


// parseFace(string)  => int
// parseSuit(string) => (bool, bool)
// handSplitter(string)  => List<string>
// parseCard(string)  => Card
// parseHand(string) => List<Card>


namespace C__Practice;

public class Card { 
    public int Face { get; set; } // an int representing the card Face
    public (bool, bool) Suit { get; set; }// a touple of (bool, bool) representing the card Suit
}

public class Parsers {

    public static Card parseCard(string cardString) { //takes a string and returns a parsed Card class
        var x = new Card {
            Face = parseFace(cardString), //call parseFace to parse the card Face
            Suit = parseSuit(cardString) //call parseSuit to parse the card Suit
        };
        return x; //return the parsed Card
    }

    public static IEnumerable<Card> parseHand(string handString) { //takes a string and return a List of Card
        Thread.Sleep(1000);
        return handSplitter(handString).Select(parseCard);//split the hand into a list of parsed cards 
    }


    public static (bool, bool) parseSuit(string card) { //takes a string and returns a touple of (bool, bool)
        if (card[1] == 'H') { //if the cards second position is an H, early out return true,true
            return (true, true);
        }

        if (card[1] == 'S') { //if the cards second position is an S, early out return true, false
            return (true, false);
        }

        if (card[1] == 'C') { //if the cards second position is a C, early out return false, true
            return (false, true);
        }

        if (card[1] == 'D') { //if the cards second position is a D, early out return false, false
            return (false, false);
        }

        return (false, false);
    }

    //       Split       ToList         
    // string => string[]  => List<string> 
    public static List<string> handSplitter(string inputString) { //takes a string and returns a list of strings
        return inputString.Split(' ').ToList(); //make a list of the input split by spaces
    }

    //      [0]     ToString  Int32.Parse 
    // "KD"  =>   'K' => "K"      =>      ??
    public static int parseFace(string inputString) { //takes a string and returns an int
        var faceToNumb = new Dictionary<string, int> { //collection of {keys, values}
            { "T", 10 },
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "A", 14 }
        };

        var faceString = inputString[0].ToString(); //take the first position of input and turn it into a string

        if (faceToNumb.ContainsKey(faceString)) { //if the dictionary faceToNumb has a key matching faceString
            return faceToNumb[faceString]; //return the value of the faceToNumb Key that matches faceString
        }

        return int.Parse(faceString); //parse the faceString into an int and return it
    }
}