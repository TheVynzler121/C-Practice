namespace C__Practice;

public class CompundSequenceTests
{
    [Test]
    public void Test_()
    {
        var numbers = new List<int>() {1,2,3,4,5,6};

        var actual = CompundSequenceAbstractions.AddTenIfBigEnough(numbers);
        
        var output = new List<int>() {14,15,16};
        Assert.That(actual, Is.EquivalentTo(output));
    }
}