namespace C__Practice;

// functions and functions calling other functions
// tests
// types: class, enum, int, string, char, bool
// conditionals: if, Dictionary

public class PokerKataTests
{

    [Test]
    public void Test_extractFace()
    {
        Assert.AreEqual(CardFace.Two, PokerKata.extractFace("2S"));
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
        Assert.AreEqual(CardFace.Ace, PokerKata.extractFace("AS"));
    }

}