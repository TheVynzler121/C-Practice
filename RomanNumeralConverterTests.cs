namespace C__Practice;

public class RomanNumeralConverterTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IIII")]
    [TestCase(5, "V")]
    [TestCase(10, "X")]
    public void Test_NumberToNumeral(int input, string output)
    {
        var actual = RomanNumeralConverter.NumberToNumeral(input);

        Assert.That(actual, Is.EqualTo(output));
    }

}