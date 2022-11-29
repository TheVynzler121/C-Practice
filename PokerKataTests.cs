namespace C__Practice;

public class PokerKataTests
{
    [Test]
    public void Test_parseFace()
    {
        // arrange
        var cardStr = "4D";
        
        // act
        var actualFace = PokerKata.parseFace(cardStr);

        // assert
        Assert.AreEqual(4, actualFace);

        Assert.AreEqual(5, PokerKata.parseFace("5D"));
    }
}