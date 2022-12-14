namespace C__Practice;

public class CompundSequenceTests
{
    // C#
    //  Compile Check -> Run Tests

    [Test]
    public void Test_FirstWordIfStartsWithT()
    {
        var items = new List<GameItem>() {
            new GameItem{ GoldCost = 200, Name = "Scream'n Sword"},
            new GameItem{ GoldCost = 700, Name = "TFragile Hammer"},
            new GameItem{ GoldCost = 700, Name = "Fragile Hammer"},
            new GameItem{ GoldCost = 100, Name = "Top of Whoop Ass"},
        };

        var actual = CompundSequenceAbstractions.FirstWordIfStartsWith(items, 'T');

        var output = new List<string>() { "TFragile", "Top" };

        Assert.That(actual, Is.EquivalentTo(output));
    }

    [Test]
    public void Test_FirstWordIfStartsWithS()
    {
        var items = new List<GameItem>() {
            new GameItem{ GoldCost = 200, Name = "Scream'n Sword"},
            new GameItem{ GoldCost = 700, Name = "Fragile Hammer"},
            new GameItem{ GoldCost = 100, Name = "Can of Whoop Ass"},
        };

        var actual = CompundSequenceAbstractions.FirstWordIfStartsWith(items, 'S');

        var output = new List<string>() { "Scream'n" };

        Assert.That(actual, Is.EquivalentTo(output));
    }
    
    [Test]
    public void Test_ItemsICanAfford()
    {
        var items = new List<GameItem>() {
            new GameItem{ GoldCost = 200, Name = "Scream'n Sword"},
            new GameItem{ GoldCost = 700, Name = "Fragile Hammer"},
            new GameItem{ GoldCost = 100, Name = "Can of Whoop Ass"},
        };

        var actual = CompundSequenceAbstractions.ItemsICanAfford(items, 300);

        var output = new List<string>() { "Scream'n Sword", "Can of Whoop Ass" };

        Assert.That(actual, Is.EquivalentTo(output));
    }

    [Test]
    public void Test_AddTenIfBigEnough()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        var actual = CompundSequenceAbstractions.AddTenIfBigEnough(numbers);

        // primitives - int, bool, string, char
        // value equality 
        // Classes - List, IEnumerable, custom classes
        // reference equality

        var output = new List<int>() { 14, 15, 16 };

        Assert.That(actual, Is.EquivalentTo(output));
    }

    [Test]
    public void Test_NamesStartingWithR()
    {
        var names = new List<string>() { "richard", "rick", "alan", "john", "ron", "randy" };

        var actual = CompundSequenceAbstractions.NamesStartingWithR(names);

        var output = new List<string>() { "Richard", "Rick", "Ron", "Randy" };

        Assert.That(actual, Is.EquivalentTo(output));
    }

    [Test]
    public void Test_ReturnNumbersGreaterThanAverage()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // 1+2+3+4+5+6+7+8+9+10/10 => 5.5

        var actual = CompundSequenceAbstractions.ReturnNumbersGreaterThanAverage(numbers);

        var output = new List<int>() { 6, 7, 8, 9, 10 };

        Assert.That(actual, Is.EquivalentTo(output));
    }
}