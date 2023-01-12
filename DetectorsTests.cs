namespace C__Practice;

public class DetectorsTests
{
    [TestCase("4D 3H 2S TD QC", 12)]
    [TestCase("4D KH 2S TD QC", 13)]
    public void Test_DetectHighCard(string input, int output)
    {
        var actual = Detectors.DetectHighCard(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("4D 3H 4S TD QC", true, 4)]
    [TestCase("4D 3H 2S TD QC", false, 0)]
    public void Test_DetectPair(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectPair(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D 3H 3S TD QC", true, 3)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectThreeOfAKind(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectThreeOfAKind(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D QH QS QD QC", true, 12)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectFourOfAKind(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectFourOfAKind(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D 3H 2C 2S 2H", true, 2)]
    [TestCase("3D 3H 3C 2S 2H", true, 3)]
    [TestCase("4D 4H 4C 5S 5H", true, 4)]
    [TestCase("4D 3H 2C 5S 6H", false, 0)]
    public void Test_DetectFullHouse(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectFullHouse(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }
    
    [TestCase("3H QH TH 4H 7H", true, 12)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectFlush(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectFlush(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3H 4H 5H 2H 6H", true, 6)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectStraight(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = Detectors.DetectStraight(input);

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }
}

// X high card
// X pair
// X three of a kind
// X straight
// X four of a kind
// X full house
// X flush
// straight flush 
// royal flush (straight flush + high card is Ace)

//TO DO: Make DetectHand tests and function.