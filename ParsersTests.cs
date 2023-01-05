// functions and functions calling other functions
// tests
// types: class, enum, int, string, char, bool, array, function, List, tuple
// conditionals: if, Dictionary
// iteratiors: foreach

// array/List - homogenous data (all exact same type)
// class/tuple - heterogenous data (all types allowed) (can hold data and/or functions)

namespace C__Practice;

public class ParsersTests
{

    [Test]
    public void Test_parseCard()
    {
        var inputString = "3D";

        var card = Parsers.parseCard(inputString);

        Assert.That(card.Face, Is.EqualTo(3));
        Assert.That(card.Suit, Is.EqualTo((false, false)));
    }

    [Test]
    public void Test_parseCard2()
    {
        var inputString = "QH";

        var card = Parsers.parseCard(inputString);

        Assert.That(card.Face, Is.EqualTo(12));
        Assert.That(card.Suit, Is.EqualTo((true, true)));
    }

    

    [Test]
    public void Test_parseSuit()
    {
        Assert.That(Parsers.parseSuit("4H"), Is.EqualTo((true, true)));
        Assert.That(Parsers.parseSuit("5S"), Is.EqualTo((true, false)));
        Assert.That(Parsers.parseSuit("6C"), Is.EqualTo((false, true)));
        Assert.That(Parsers.parseSuit("TD"), Is.EqualTo((false, false)));
    }

    [Test]
    public void Test_tuplePractice()
    {
        var t1 = (1, 3);
        var t2 = (2, 1);

        var areEqual = (1, 3) == (1, 3);

        Assert.That(areEqual, Is.True);

        Assert.That(t1, Is.EqualTo((1, 3)));
        Assert.That(t1, Is.Not.EqualTo(t2));

        Assert.That(t2, Is.EqualTo((2, 1)));
        Assert.That(t2, Is.Not.EqualTo(t1));
    }

    [Test]
    public void Test_handSplitter()
    {
        var inputString = "4D 3H 2S TD QC";

        var cardStrings = Parsers.handSplitter(inputString);

        Assert.That(cardStrings, Is.EquivalentTo(new List<string>() { "4D", "3H", "2S", "TD", "QC" }));
    }

    [TestCase("4D", 4)]
    [TestCase("5D", 5)]
    [TestCase("6D", 6)]
    [TestCase("TD", 10)]
    [TestCase("JD", 11)]
    [TestCase("QD", 12)]
    [TestCase("KD", 13)]
    [TestCase("AD", 14)]
    public void Test_parseFace(string inputString, int expected)
    {
        var face = Parsers.parseFace(inputString);

        Assert.That(face, Is.EqualTo(expected));
    }

}