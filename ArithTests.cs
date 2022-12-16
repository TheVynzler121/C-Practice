namespace C__Practice;

public class ArithTests
{

    [Test]

    public void Test_Arith()
    {
        Assert.That(Arith.add(2, 3), Is.EqualTo(5));
        Assert.That(Arith.subtract(3, 2), Is.EqualTo(1));

    }

    [Test]
    public void Test_countNumbers(){
        var numberInput = new[] {"1", "2", "2", "3", "3", "1", "3"};

        var finalNumberCount = Arith.countNumbers(numberInput);

        Assert.That(finalNumberCount["1"], Is.EqualTo(2));
        Assert.That(finalNumberCount["2"], Is.EqualTo(2));
        Assert.That(finalNumberCount["3"], Is.EqualTo(3));
    }

    [Test]
    public void Test_extractNumber(){
        
        Assert.That(Arith.extractNumber("4"), Is.EqualTo(NumbersList.Four));
    }

    [Test]
    public void Test_extractNumber2(){
        
        Assert.That(Arith.extractNumber2("5"), Is.EqualTo(NumbersListTwo.Five));
        Assert.That(Arith.extractNumber2("9"), Is.EqualTo(NumbersListTwo.Nine));
    }
}