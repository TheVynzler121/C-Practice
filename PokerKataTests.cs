namespace C__Practice;

public class PokerKataTests
{

    [Test]
    public void Test_parseSuit()
    {
        Assert.AreEqual(Suit.Diamonds, PokerKata.parseSuit("5D"));
        Assert.AreEqual(Suit.Spades, PokerKata.parseSuit("5S"));
        Assert.AreEqual(Suit.Clubs, PokerKata.parseSuit("3C"));
        Assert.AreEqual(Suit.Hearts, PokerKata.parseSuit("6H"));
    }

    [Test]
    public void Test_parseFace_numericFace()
    {
        //arrange
        var cardStr = "4D";

        //act
        var actualFace = PokerKata.parseFace(cardStr);

        //assert
        Assert.AreEqual(4, actualFace);

        Assert.AreEqual(5, PokerKata.parseFace("5D"));
    }

    [Test]
    public void Test_parseFace_FaceCards()
    {
        //arrange
        var cardStr = "TD";

        //act
        var actualFace = PokerKata.parseFace(cardStr);

        //assert
        Assert.AreEqual(10, actualFace);
        Assert.AreEqual(11, PokerKata.parseFace("JD"));
        Assert.AreEqual(12, PokerKata.parseFace("QD"));
        Assert.AreEqual(13, PokerKata.parseFace("KD"));
        Assert.AreEqual(14, PokerKata.parseFace("AD"));
    }
}