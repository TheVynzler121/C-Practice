namespace C__Practice;

public class ArithTests
{

    [Test]

    public void Test_Arith()
    {
        Assert.That(Arith.add(2, 3), Is.EqualTo(5));
        Assert.That(Arith.subtract(3, 2), Is.EqualTo(1));

    }
}