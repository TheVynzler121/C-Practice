namespace C__Practice;

// functions and functions calling other functions
// tests
// types: class, enum, int, string, char, bool, array
// conditionals: if, Dictionary

// array - homogenous data (all exact same type)
// class - heterogenous data (all types allowed)

// class      Organization
//    string  Name
//    class   Address
//       string Street
//       string City
//       string State
//       int ZipCode

//    class   MTGPlayfield
//       Card[] Monsters
//          string Name
//          string Flavor
//          string Rarity
//          int Mana
//       string Lands
//       string Artifacts
//       int Health

// var aceofSpades = new Card() {
//     face = CardFace.Ace,
//     suit = CardSuit.Spades
// };

// var theSuit = aceofSpades.suit;


public class PokerKataTests
{

    [Test]
    public void Test_CountStrings()
    {
        var inputStrings = new [] { "A", "A", "D", "C", "A", "C", "D", "A"};

        var finalCounts = PokerKata.countStrings(inputStrings);

        Assert.AreEqual(4, finalCounts["A"]);
        Assert.AreEqual(2, finalCounts["D"]);
        Assert.AreEqual(2, finalCounts["C"]);
    }

    [Test]
    public void Test_CountStrings1()
    {
        var strings = new [] { "D", "A", "D", "C", "A", "D" }; // setting a new array/list

        var counts = PokerKata.countStrings(strings); // Calls the countStrings() function with the array varible strings as its parameter. then assigns the result of countStrings() as a new var called counts

        Assert.AreEqual(2, counts["A"]); // Checks if there are 2 "A"s found in the above array/list
        Assert.AreEqual(3, counts["D"]); // Checks if there are 3 "D"s in the above array/list
        Assert.AreEqual(1, counts["C"]); // Checks if there is 1 "C" in the above array/list
    }

    [Test]
    public void Test_extractFace()
    {
        Assert.AreEqual(CardFace.Two, PokerKata.extractFace("2D"));
        Assert.AreEqual(CardFace.Three, PokerKata.extractFace("3S"));
        Assert.AreEqual(CardFace.Four, PokerKata.extractFace("4D"));
        Assert.AreEqual(CardFace.Five, PokerKata.extractFace("5H"));
        Assert.AreEqual(CardFace.Six, PokerKata.extractFace("6C"));
        Assert.AreEqual(CardFace.Seven, PokerKata.extractFace("7D"));
        Assert.AreEqual(CardFace.Eight, PokerKata.extractFace("8H"));
        Assert.AreEqual(CardFace.Nine, PokerKata.extractFace("9C"));
        Assert.AreEqual(CardFace.Ten, PokerKata.extractFace("TS"));
        Assert.AreEqual(CardFace.Jack, PokerKata.extractFace("JS"));
        Assert.AreEqual(CardFace.Queen, PokerKata.extractFace("QH"));
        Assert.AreEqual(CardFace.King, PokerKata.extractFace("KC"));
        Assert.AreEqual(CardFace.Ace, PokerKata.extractFace("AH"));
    }

    [Test]
    public void Test_extractSuit()
    {
        Assert.AreEqual(CardSuit.Diamonds, PokerKata.extractSuit("3D"));
        Assert.AreEqual(CardSuit.Spades, PokerKata.extractSuit("6S"));
        Assert.AreEqual(CardSuit.Clubs, PokerKata.extractSuit("TC"));
        Assert.AreEqual(CardSuit.Hearts, PokerKata.extractSuit("2H"));
        
    }
}