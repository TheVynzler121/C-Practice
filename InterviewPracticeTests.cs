namespace C__Practice;

public class InterviewPracticeTests {
    [TestCase("success", true)]
    [TestCase("test", false)]
    [TestCase("tess", true)]
    [TestCase("abcdeff", true)]
    public void Test_ConsecutiveDuplicates(string input, bool output) {
        // "abcde" -> false
        // "abccde" -> true
        // "a" -> false
        // "" -> false
        // "aa" -> true
        var actual = InterviewPractice.ConsecutiveDuplicates(input);

        Assert.That(actual, Is.EqualTo(output));  
    }

    
    [Test]
    public void Test_ReverseString(){
        var input = new List<string>() {"h","e","l","l","o"};

        var actual = InterviewPractice.ReverseString(input);

        var output = new List<string>() {"o","l","l","e","h"};

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ReverseString2(){
        var input = new List<string>() {"H","a","n","n","a","h"};

        var actual = InterviewPractice.ReverseString(input);

        var output = new List<string>() {"h","a","n","n","a","H"};

        Assert.That(actual, Is.EqualTo(output));
    }
}