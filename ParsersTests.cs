namespace C__Practice;

// functions and functions calling other functions
// tests
// types: class, enum, int, string, char, bool, array, function
// conditionals: if, Dictionary
// iteratiors: foreach

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
// var theFace = aceofSpades.face;

// aceOfSpades.suit = CardSuit.Hearts
// aceOfSpades.suit == CardSuit.Hearts
// return aceOfSpades;


public class ParsersTests
{

    [Test]
    public void Test_CountStrings()
    {
        var inputStrings = new[] { "A", "A", "D", "C", "A", "C", "D", "A" };

        var finalCounts = Parsers.countStrings(inputStrings);

        Assert.That(finalCounts["A"], Is.EqualTo(4));
        Assert.That(finalCounts["D"], Is.EqualTo(2));
        Assert.That(finalCounts["C"], Is.EqualTo(2));
    }

    [Test]
    public void Test_ParseCards()
    {
        var cardsString = "4D 3H 2S TD QC 5D"; // new [] { "4D", "3H", "2S", "TD", "QC" }
        var cards = Parsers.parseCards(cardsString);
        Assert.That(cards.Count, Is.EqualTo(6));
        Assert.That(cards[0].face, Is.EqualTo(CardFace.Four)); 
        Assert.That(cards[0].suit, Is.EqualTo(CardSuit.Diamonds)); 
        Assert.That(cards[4].face, Is.EqualTo(CardFace.Queen)); 
        Assert.That(cards[4].suit, Is.EqualTo(CardSuit.Clubs)); 
        Assert.That(cards[5].face, Is.EqualTo(CardFace.Five)); 
        Assert.That(cards[5].suit, Is.EqualTo(CardSuit.Diamonds)); 
    }

    [Test]
    public void Test_CountStrings1()
    {
        var strings = new[] { "D", "A", "D", "C", "A", "D" }; // setting a new array/list

        var counts = Parsers.countStrings(strings); // Calls the countStrings() function with the array varible strings as its parameter. then assigns the result of countStrings() as a new var called counts

        Assert.That(counts["A"], Is.EqualTo(2)); // Checks if there are 2 "A"s found in the above array/list
        Assert.That(counts["D"], Is.EqualTo(3)); // Checks if there are 3 "D"s in the above array/list
        Assert.That(counts["C"], Is.EqualTo(1)); // Checks if there is 1 "C" in the above array/list
    }

    [Test]
    public void Test_parseCard()
    {
        var theCard = Parsers.parseCard("2D");
        Assert.That(theCard.face, Is.EqualTo(CardFace.Two));
        Assert.That(theCard.suit, Is.EqualTo(CardSuit.Diamonds));
    }

    [Test]
    public void Test_parseCard1()
    {
        var theCard = Parsers.parseCard("5H");
        Assert.That(theCard.face, Is.EqualTo(CardFace.Five));
        Assert.That(theCard.suit, Is.EqualTo(CardSuit.Hearts));
    }

    [Test]
    public void Test_parseCard2()
    {
        var theCard = Parsers.parseCard("QS");
        Assert.That(theCard.face, Is.EqualTo(CardFace.Queen));
        Assert.That(theCard.suit, Is.EqualTo(CardSuit.Spades));
    }

    [Test]
    public void Test_extractFace()
    {
        Assert.That(Parsers.extractFace("2D"), Is.EqualTo(CardFace.Two));
        Assert.That(Parsers.extractFace("3S"), Is.EqualTo(CardFace.Three));
        Assert.That(Parsers.extractFace("4D"), Is.EqualTo(CardFace.Four));
        Assert.That(Parsers.extractFace("5H"), Is.EqualTo(CardFace.Five));
        Assert.That(Parsers.extractFace("6C"), Is.EqualTo(CardFace.Six));
        Assert.That(Parsers.extractFace("7D"), Is.EqualTo(CardFace.Seven));
        Assert.That(Parsers.extractFace("8H"), Is.EqualTo(CardFace.Eight));
        Assert.That(Parsers.extractFace("9C"), Is.EqualTo(CardFace.Nine));
        Assert.That(Parsers.extractFace("TS"), Is.EqualTo(CardFace.Ten));
        Assert.That(Parsers.extractFace("JS"), Is.EqualTo(CardFace.Jack));
        Assert.That(Parsers.extractFace("QH"), Is.EqualTo(CardFace.Queen));
        Assert.That(Parsers.extractFace("KC"), Is.EqualTo(CardFace.King));
        Assert.That(Parsers.extractFace("AH"), Is.EqualTo(CardFace.Ace));
    }


    [Test]
    public void Test_extractSuit()
    {
        Assert.That(Parsers.extractSuit("3D"), Is.EqualTo(CardSuit.Diamonds));
        Assert.That(Parsers.extractSuit("6S"), Is.EqualTo(CardSuit.Spades));
        Assert.That(Parsers.extractSuit("TC"), Is.EqualTo(CardSuit.Clubs));
        Assert.That(Parsers.extractSuit("2H"), Is.EqualTo(CardSuit.Hearts));

    }
}