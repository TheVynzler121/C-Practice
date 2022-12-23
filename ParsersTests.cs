// functions and functions calling other functions
// tests
// types: class, enum, int, string, char, bool, array, function, List
// conditionals: if, Dictionary
// iteratiors: foreach

// array - homogenous data (all exact same type)
// class - heterogenous data (all types allowed) (can hold data and/or functions)

namespace C__Practice;

public class ParsersTests
{


    [Test]
    public void Test_handSplitter()
    {
        var inputString = "4D 3H 2S TD QC";

        var cardStrings = Parsers.handSplitter(inputString);

        Assert.That(cardStrings, Is.EquivalentTo(new List<string>(){"4D", "3H", "2S", "TD", "QC"}));
    }

    // "3D"  => 3
    // "4D"  => 4
    // "5D"  => 5
    // "6D"  => 6
    // "KD"  => 13
    // "AD"  => 14

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