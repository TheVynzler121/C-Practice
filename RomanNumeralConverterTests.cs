namespace C__Practice;

public class RomanNumeralConverterTests {
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
    [TestCase(15, "XV")]
    [TestCase(16, "XVI")]
    [TestCase(17, "XVII")]
    [TestCase(18, "XVIII")]
    [TestCase(19, "XVIIII")]
    [TestCase(20, "XX")]
    [TestCase(30, "XXX")]
    [TestCase(40, "XXXX")]
    [TestCase(49, "XXXXVIIII")]
    [TestCase(50, "L")]
    [TestCase(51, "LI")]
    [TestCase(55, "LV")]
    [TestCase(99, "LXXXXVIIII")]
    [TestCase(100, "C")]
    [TestCase(200, "CC")]
    [TestCase(300, "CCC")]
    [TestCase(400, "CCCC")]
    [TestCase(499, "CCCCLXXXXVIIII")]
    public void Test_NumberToNumeral(int input, string output) {
        var actual = RomanNumeralConverter.NumberToNumeral(input);

        Assert.That(actual, Is.EqualTo(output));
    }

// 1,5,10
    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("IX", 9)]
    [TestCase("X", 10)]
    [TestCase("XIV", 14)]
    [TestCase("XV", 15)]
    [TestCase("XIX", 19)]
    [TestCase("XX", 20)]
    [TestCase("XL", 40)]
    [TestCase("L", 50)]
    [TestCase("XC", 90)]
    [TestCase("XCI", 91)]
    [TestCase("C", 100)]
    [TestCase("CIX", 109)]
    [TestCase("CX", 110)]
    [TestCase("CXCI", 191)]
    [TestCase("CCCXCIX", 399)]
    [TestCase("CD", 400)]
    [TestCase("D", 500)]
    [TestCase("DCCCXCIX", 899)]
    [TestCase("CM", 900)]
    [TestCase("CMXCIX", 999)]
    [TestCase("M", 1000)]
    [TestCase("MI", 1001)]
    public void Test_RomanToArabic(string input, int output) {
        Assert.That(RomanNumeralConverter.RomanToArabic(input), Is.EqualTo(output));
    }
}