namespace C__Practice;

public class Tests
{
    [Test]
    public void Test_add()
    {
        Assert.AreEqual(2, Arith.add(1, 1));       
    }

    [Test]
    public void Test_subtract()
    {
        Assert.AreEqual(4, Arith.subtract(6, 2));
    }

    [Test]
    public void Test_multiply()
    {
        Assert.AreEqual(30, Arith.multiply(15, 2));
    }

     [Test]
    public void Test_divide()
    {
        Assert.AreEqual(12, Arith.divide(24, 2));
    }

     [Test]
    public void Test_hello()
    {
        Assert.AreEqual("Hi richard", Arith.hello("richard"));
    }
}