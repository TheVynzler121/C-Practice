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
    public void Test_GoldCostIfStartsWithS()
    {
        var items = new List<GameItem>() {
            new GameItem{ GoldCost = 200, Name = "Scream'n Sword"},
            new GameItem{ GoldCost = 700, Name = "Fragile Hammer"},
            new GameItem{ GoldCost = 100, Name = "Can of Whoop Ass"},
            new GameItem{ GoldCost = 4000, Name = "Sphere of Power"}
        };

        var actual = CompundSequenceAbstractions.GoldCostIfStartsWithS(items, 'S');

        var output = new List<int>() { 200, 4000 };

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
    public void Test_NumbersLargerThanFiveToString()
    {
        var input = new List<int>() {1, 2, 6, 3, 77, 5, 4, 8};

        var actual = CompundSequenceAbstractions.NumbersLargerThanFiveToString(input);

        var output = new List<string>() {"6", "77", "8"};

        Assert.That(actual, Is.EquivalentTo(output));
    }

    [Test]
    public void Test_SumOfNumbersLargerThanSeven()
    {
        var input = new List<int> {2, 3, 1, 5, 8, 88, 9, 10, 6};

        var actual = CompundSequenceAbstractions.SumOfNumbersLargerThanSeven(input);

        var output = 115;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_NumberOfWordsToString()
    {
        var input = new List<string> {"Hello", "Richard", "Today", "Dog", "Hamburger"};

        var actual = CompundSequenceAbstractions.NumberOfWordsToString(input);

        Assert.That(actual, Is.EqualTo("There are 5 words"));
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

    [TestCase( "1113asdfladfj4451311111234340afljl111;g511111231113dfadffjlh21", '1')]
    [TestCase( "331", '3')]
    [TestCase( "3144444", '4')]
    [TestCase("aaaaaa114j88", 'a')]
    public void Test_HighestFrequencyCharacter(string input, char output)
    {
        var actual = CompundSequenceAbstractions.HighestFrequencyCharacter(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    // rules we can break:
    // can have: loops, conditionals, data structures, any number of asserts
    // can call RollDice as many times as you want
    // must prove reasonably that the dice isn't weighted
    [Test]
    public void Test_IsDiceWeighted()
    {
        // need a var to store the roll results
        
        var rolls = new List<int>();
        var timesWeAreRolling = 5000000;

        for (int x = 0; x < timesWeAreRolling; x++)
        {
            rolls.Add(CompundSequenceAbstractions.RollDice());        
        }
      
        // need to store and count those results
        var rollCounts = new Dictionary<int, int>();
        foreach (var roll in rolls)
        {
            if(rollCounts.ContainsKey(roll))
            {
                rollCounts[roll]++;
            }
            else
            {
                rollCounts[roll] = 1;
            }
        }
        CompundSequenceAbstractions.PrintDictionary(rollCounts);
        var averageRollCount = timesWeAreRolling/6;
        var graceZone = averageRollCount * 0.1;
        foreach (var roll in rollCounts)
        {
            var tenPercentOver = averageRollCount + graceZone;
            var tenPercentUnder = averageRollCount - graceZone;
            if(roll.Value > tenPercentOver || roll.Value < tenPercentUnder)
            {
                Assert.Fail($"{roll.Value} was not {averageRollCount}");
            } 
        }
    }
}