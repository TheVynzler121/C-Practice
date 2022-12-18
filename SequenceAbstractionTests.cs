namespace C__Practice;

public class SequenceAbstractionTests
{
// MAP, FILTER, FOLD/REDUCE
// FOLDS/REDUCE- take a list, return one thing (that isn't a list)
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
}
