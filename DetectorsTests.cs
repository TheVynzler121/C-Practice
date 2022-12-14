namespace C__Practice;

public class DetectorsTests
{
      [Test]
    public void Test_detectHand_FourKings()
    {
        var hand = Parsers.parseCards("KD KH KS TD KC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("Four of a kind: King"));
    }

      [Test]
    public void Test_detectHand_ThreeKings()
    {
        var hand = Parsers.parseCards("KD KH KS TD QC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("Three of a kind: King"));
    }

    [Test]
    public void Test_detectHand_PairKings()
    {
        var hand = Parsers.parseCards("KD KH 2S TD QC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("Pair: King"));
    }

    [Test]
    public void Test_detectHand_PairQueen()
    {
        var hand = Parsers.parseCards("4D QH 2S TD QC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("Pair: Queen"));
    }

    [Test]
    public void Test_detectHand_HighCard()
    {
        var hand = Parsers.parseCards("4D 3H 2S TD QC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("HighCard: Queen Clubs"));
    }

    [Test]
    public void Test_detectHand_HighCard1()
    {
        var hand = Parsers.parseCards("4D 3H 2S KD QC");
        Assert.That(Detectors.detectHand(hand), Is.EqualTo("HighCard: King Diamonds"));
    }
}