namespace C__Practice;

public class RomanNumeralConverterTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IIII")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9, "VIIII")]
    [TestCase(10, "X")]
    [TestCase(11, "XI")]
    [TestCase(12, "XII")]
    [TestCase(13, "XIII")]
    [TestCase(14, "XIIII")]
    public void Test_NumberToNumeral(int input, string output)
    {
        var actual = RomanNumeralConverter.NumberToNumeral(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("III", 3)]
    [TestCase("IIII", 4)]
    [TestCase("V", 5)]
    [TestCase("VI", 6)]
    [TestCase("VII", 7)]
    [TestCase("VIII", 8)]
    [TestCase("VIIII", 9)]
    [TestCase("X", 10)]
    [TestCase("XI", 11)]
    [TestCase("XII", 12)]
    [TestCase("XIII", 13)]
    [TestCase("XIIII", 14)]
    [TestCase("XXXXVIIII", 49)]
    public void Test_RomanToArabic(string input, int output)
    {
        Assert.That(RomanNumeralConverter.RomanToArabic(input), Is.EqualTo(output));
    }

}