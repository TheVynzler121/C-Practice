namespace C__Practice;

public class FormattersTests
{

    [Test]
    public void Test_formatFace()
    {
        var input = 11;

        var faceString = Formatters.formatFace(input);

        Assert.That(faceString, Is.EqualTo("Jack"));
    }

    [Test]
    public void Test_printCard3D()
    {
        var inputString = "3D";

        var card = Formatters.printCard(inputString);

        Assert.That(card, Is.EqualTo("Three Diamonds"));
    }

    [Test]
    public void Test_printCard()
    {
        var inputString = "QH";

        var card = Formatters.printCard(inputString);

        Assert.That(card, Is.EqualTo("Queen Hearts"));
    }

    [Test]
    public void Test_canFormatASuit()
    {
        var hearts = (true, true);
        var spades = (true, false);
        var clubs = (false, true);
        var diamonds = (false, false);

        Assert.That(Formatters.formatSuit(hearts), Is.EqualTo("Hearts"));
        Assert.That(Formatters.formatSuit(spades), Is.EqualTo("Spades"));
        Assert.That(Formatters.formatSuit(clubs), Is.EqualTo("Clubs"));
        Assert.That(Formatters.formatSuit(diamonds), Is.EqualTo("Diamonds"));
    }
}