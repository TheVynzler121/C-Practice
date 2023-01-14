namespace C__Practice;

public class DetectorsTests
{
    [TestCase("4D 3H 2S TD QC", 12)]
    [TestCase("4D KH 2S TD QC", 13)]
    public void Test_DetectHighCard(string input, int output)
    {
        var actual = new Detectors(input).DetectHighCard();

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("4D 3H 4S TD QC", true, 4)]
    [TestCase("4D 3H 2S TD QC", false, 0)]
    public void Test_DetectPair(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectPair();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D 3H 3S TD QC", true, 3)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectThreeOfAKind(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectThreeOfAKind();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D QH QS QD QC", true, 12)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectFourOfAKind(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectFourOfAKind();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3D 3H 2C 2S 2H", true, 2)]
    [TestCase("3D 3H 3C 2S 2H", true, 3)]
    [TestCase("4D 4H 4C 5S 5H", true, 4)]
    [TestCase("4D 3H 2C 5S 6H", false, 0)]
    public void Test_DetectFullHouse(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectFullHouse();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }
    
    [TestCase("3H QH TH 4H 7H", true, 12)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectFlush(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectFlush();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3H 4D 5H 2H 6H", true, 6)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectStraight(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectStraight();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("3H 4H 5H 2H 6H", true, 6)]
    [TestCase("2D 3H 4S TD QC", false, 0)]
    public void Test_DetectStraightFlush(string input, bool isMatch, int tieBreakerFace)
    {
        var actual = new Detectors(input).DetectStraightFlush();

        Assert.That(actual.IsMatch, Is.EqualTo(isMatch));
        Assert.That(actual.TieBreaker, Is.EqualTo(tieBreakerFace));
    }

    [TestCase("AH KH QH TH JH", true)]
    [TestCase("2D 3H 4S TD QC", false)]
    public void Test_DetectRoyalFlush(string input, bool isMatch)
    {
        bool actuallyIsMatch = new Detectors(input).DetectRoyalFlush();

        Assert.That(actuallyIsMatch, Is.EqualTo(isMatch));
    }

    [TestCase("AH KH QH TH JH", HandRank.RoyalFlush, 14)]
    [TestCase("4H 5H 2H 6H 3H", HandRank.StraightFlush, 6)]
    [TestCase("5H 5H 5H 5H 2H", HandRank.FourOfAKind, 5)]
    [TestCase("3D 3H 3C 2S 2H", HandRank.FullHouse, 3)]
    [TestCase("4D 4H 4C 2S 2H", HandRank.FullHouse, 4)]
    [TestCase("4H 5H 2H 2H 2H", HandRank.Flush, 5)]
    [TestCase("4D 5D 2H 6H 3H", HandRank.Straight, 6)]
    [TestCase("4D 5H 2C 2S 2H", HandRank.ThreeOfAKind, 2)]
    [TestCase("4D 5H TC 2S 2H", HandRank.Pair, 2)]
    [TestCase("4D 9H 2H 6H 3H", HandRank.HighCard, 9)]
    public void Test_DetectHand(string input, HandRank rank, int tieBreaker)
    {
        var rankResults = new Detectors(input).DetectHand();

        Assert.That(rankResults.Rank, Is.EqualTo(rank));
        Assert.That(rankResults.TieBreaker, Is.EqualTo(tieBreaker));
    }
}

//TO DO: Make CompareHand tests and function.