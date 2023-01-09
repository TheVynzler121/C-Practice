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
    public void Test_DetectPair(string input, string output)
    {
        var actual = Detectors.DectectPair(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    
}