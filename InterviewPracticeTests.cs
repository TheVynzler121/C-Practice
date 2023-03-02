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

    [Test]
    public void Test_TwoSum(){
        var input = new List<int>() {2,7,11,15};
        var target = 9;

        var actual = InterviewPractice.TwoSum(input, target);

        var output = new List<int>() {0, 1};

        Assert.That(actual, Is.EqualTo(output));
    }
    [Test]
    public void Test_TwoSum2(){
        var input = new List<int>() {3,2,4};
        var target = 6;

        var actual = InterviewPractice.TwoSum(input, target);

        var output = new List<int>() {1, 2};

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("leetcode", 0)]
    [TestCase("loveleetcode", 2)]
    [TestCase("aabb", -1)]
    public void Test_FirstNonrepeatingChar(string input, int output){
        var actual = InterviewPractice.FirstNonrepeatingChar(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_PlusOne(){
        var input = new List<int>() {1,2,3};

        var actual = InterviewPractice.PlusOne(input);

        var output = new List<int>() {1,2,4};

        Assert.That(actual, Is.EqualTo(output));
    }
}