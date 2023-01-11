namespace C__Practice;

public class DetectorsTests
{
    [TestCase("4D 3H 2S TD QC", "High card is : Queen Clubs")]
    [TestCase("4D KH 2S TD QC", "High card is : King Hearts")]
    public void Test_DetectHighCard(string input, string output)
    {
        var actual = Detectors.DetectHighCard(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("4D 3H 4S TD QC", "Pair of : Four")]
    [TestCase("2D 3H 4S TD QC", null)]
    public void Test_DetectPair(string input, string output)
    {
        var actual = Detectors.DectectPair(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("3D 3H 3S TD QC", "Three of a kind : Three")]
    [TestCase("2D 3H 4S TD QC", null)]
    public void Test_DetectThreeOfAKind(string input, string output)
    {
        var actual = Detectors.DectectThreeOfAKind(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("3D QH QS QD QC", "Four of a kind : Queen")]
    [TestCase("2D 3H 4S TD QC", null)]
    public void Test_DetectFourOfAKind(string input, string output)
    {
        var actual = Detectors.DectectFourOfAKind(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("3D 3H 2C 2S 2H", "Full House : Two")]
    [TestCase("3D 3H 3C 2S 2H", "Full House : Three")]
    [TestCase("4D 4H 4C 5S 5H", "Full House : Four")]
    [TestCase("4D 3H 2C 5S 6H", null)]
    public void Test_DetectFullHouse(string input, string output)
    {
        var actual = Detectors.DetectFullHouse(input);

        Assert.That(actual, Is.EqualTo(output));
    }
    //TO DO: Make DetectHand tests and function. Make Full House function.
}