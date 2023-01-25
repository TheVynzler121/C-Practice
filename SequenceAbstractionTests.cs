namespace C__Practice;

public class SequenceAbstractionTests
{
	// level 1 - foreach, Select, Where
	// level 2 - compound transformations

// MAP, FILTER, FOLD/REDUCE
// FOLDS/REDUCE- take a list, return one thing
// List<T>    - T is a placeholder for the generic
// Aggregate (fold/reduce) - List<T> => U          Func<List<T>, U>      - always collapses the whole list into one thing
// Select (map)         - List<T> => List<U>    Func<List<T>, List<U> - list always the same size (one shape of a list to another shape thats the same size)
// Where (filter)      - returns the same type and keeps certain elements. (also has an if statement)

    [Test]
    public void Test_NumbersAreSmallerThan5() {
	var items = new List<int> {1, 55, 2, 6};

	var actual = SequenceAbstraction.NumbersSmallerThan5(items);

	Assert.That(actual, Is.EquivalentTo(new List<int> {1, 2}));
    }

	[Test]
    public void Test_NumbersAreSmallerThan5Two() {
	var items = new List<int> {1, 55, 2, 6, 3, 7, 4, 20};

	var actual = SequenceAbstraction.NumbersSmallerThan5(items);

	Assert.That(actual, Is.EquivalentTo(new List<int> {1, 2, 3, 4}));
    }

    [Test]
    public void Test_WordsStartWithS() {
	var items = new List<string> {"steve", "ta", "s", "horseface"};

	var actual = SequenceAbstraction.WordsStartWithS(items);

	Assert.That(actual, Is.EquivalentTo(new List<string> { "steve", "s"}));
    }

    [Test]
    public void Test_WordsLongEnough() {
	var items = new List<string> {"steve", "sa", "s", "horseface"};

	var actual = SequenceAbstraction.WordsLongEnough(items);

	Assert.That(actual, Is.EquivalentTo(new List<string> { "steve", "horseface"}));
    }

    [Test]
    public void Test_GameItemsICanAfford() {
	var items = new List<int> { 400, 800, 200 };

	var actual = SequenceAbstraction.NumbersUnder500(items);

	Assert.That(actual, Is.EquivalentTo(new List<int> { 400, 200 }));
    }

    [Test]
    public void Test_GameItemTotal() {
	var items = new List<GameItem> {
		new GameItem { Name = "Orb of Uh", GoldCost = 400},
		new GameItem { Name = "Sword Of Fire", GoldCost = 800}
	};

	var actual = SequenceAbstraction.TotalCost(items);

	Assert.That(actual, Is.EqualTo(1200));
    }

    [Test]
    public void Test_GetGoldCosts() {
	var items = new List<GameItem> {
		new GameItem { Name = "Orb of Uh", GoldCost = 400},
		new GameItem { Name = "Sword Of Fire", GoldCost = 800}
	};

	var actual = SequenceAbstraction.GetGoldCosts(items);

	Assert.That(actual, Is.EquivalentTo(new List<int> { 400, 800 }));
    }

    [Test]
    public void Test_SumOfSquares() {
	var numbs = new List<int> {4, 5};  // (4*4)*2 , (5*5)*2

	var actual = SequenceAbstraction.SumOfSquares(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<int> { 32, 50 }));
    }

    [Test]
    public void Test_FirstLetterCapitalized() {
	var numbs = new List<string> {"steve", "horseface"}; 

	var actual = SequenceAbstraction.FirstLetterCapitalized(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<string> { "S", "H" }));
    }

	[Test]
    public void Test_FirstLetterCapitalized2() {
	var numbs = new List<string> {"jim", "nukedem", "honeybadger"}; 

	var actual = SequenceAbstraction.FirstLetterCapitalized(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<string> { "J", "N", "H" }));
	}

    [Test]
    public void Test_CountDigits() {
	var numbs = new List<int> { 1, 200, 12345, 24};

	var actual = SequenceAbstraction.CountDigits(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<int> {1, 3, 5, 2}));
    }

    [Test]
    public void Test_IntToString() {
	var numbs = new List<int> { 1, 2, 3, 4};

	var actual = SequenceAbstraction.IntsToStrings(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<string> { "1", "2", "3", "4"}));
    }

    [Test]
    public void Test_AddsTen() {
	var numbs = new List<int> { 1, 2, 3, 4};

	var actual = SequenceAbstraction.AddsTen(numbs);

	Assert.That(actual, Is.EquivalentTo(new List<int> { 11, 12, 13, 14}));
    }

    [Test]
    public void Test_SumNumbers() {
	var numbs = new List<int> { 1, 2, 3, 4};

	var actual = SequenceAbstraction.SumNumbers(numbs);

	Assert.That(actual, Is.EqualTo(10));
    }

    [Test]
    public void Test_CountStrings() {
	var names = new List<string> {"Steve", "Sam", "Stephanie"};

	var actual = SequenceAbstraction.CountStrings(names);

	Assert.That(actual, Is.EqualTo(3));
    }


    [Test]
    public void Test_MergeStrings() {
	var names = new List<string> {"Steve", "was", "here"};

	var actual = SequenceAbstraction.MergeStrings(names);

	Assert.That(actual, Is.EqualTo("Stevewashere"));
    }

    [Test]
    public void Test_FirstLetters() {
	var names = new List<string> {"flats", "are", "really", "tight"};

	var actual = SequenceAbstraction.FirstLetters(names);

	Assert.That(actual, Is.EqualTo("fart"));
    }

    [Test]
    public void Test_CountWordLengths() {
	var names = new List<string> {"flats", "are", "really", "tight"};

	var actual = SequenceAbstraction.CountWordLengths(names);

	Assert.That(actual, Is.EqualTo(5+3+6+5));
    }

    [Test]
    public void Test_AreAllMoreThanThreeCharacters() {
	var names = new List<string> {"flats", "really", "tight"};

	var actual = SequenceAbstraction.AreAllMoreThanThreeLength(names);

	Assert.That(actual, Is.EqualTo(true));
    }

    [Test]
    public void Test_AreAllMoreThanThreeCharacters_Test2() {
	var names = new List<string> {"flats", "ha", "tight"};

	var actual = SequenceAbstraction.AreAllMoreThanThreeLength(names);

	Assert.That(actual, Is.EqualTo(false));
    }

	[Test]
	public void Test_AddEmUp()
	{
		var input = new List<int>() {5, 7, 10, 3};

		var actual = SequenceAbstraction.AddEmUp(input);

		var output = 25;

		Assert.That(actual, Is.EqualTo(output));
	}

	[Test]
	public void Test_AddEvenUp()
	{
		var input = new List<int>() {2, 3, 6, 1, 20};

		var actual = SequenceAbstraction.AddEvenUp(input);

		var output = 28;

		Assert.That(actual, Is.EqualTo(output));
	}
}
