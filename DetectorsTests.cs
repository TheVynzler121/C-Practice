namespace C__Practice;

public class DetectorsTests
{

    // "4D 3H 2S TD QC" -> "high card: queen clubs"


    // "4D 3H 2S TD QC"   ->  Split ' ' -> ExtractFace -> Sort By Extracted Face -> Return
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