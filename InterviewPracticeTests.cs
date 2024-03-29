namespace C__Practice;

public class InterviewPracticeTests
{
    [TestCase("success", true)]
    [TestCase("test", false)]
    [TestCase("tess", true)]
    [TestCase("abcdeff", true)]
    [TestCase("lpla", false)]
    public void Test_ConsecutiveDuplicates(string input, bool output)
    {
        // "abcde" -> false
        // "abccde" -> true
        // "a" -> false
        // "" -> false
        // "aa" -> true
        var actual = InterviewPractice.ConsecutiveDuplicates(input);

        Assert.That(actual, Is.EqualTo(output));
    }


    [Test]
    public void Test_ReverseString()
    {
        var input = new List<string>() { "h", "e", "l", "l", "o" };

        var actual = InterviewPractice.ReverseString(input);

        var output = new List<string>() { "o", "l", "l", "e", "h" };

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ReverseString2()
    {
        var input = new List<string>() { "H", "a", "n", "n", "a", "h" };

        var actual = InterviewPractice.ReverseString(input);

        var output = new List<string>() { "h", "a", "n", "n", "a", "H" };

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_TwoSum()
    {
        var input = new List<int>() { 2, 7, 11, 15 };
        var target = 9;

        var actual = InterviewPractice.TwoSum(input, target);

        var output = new List<int>() { 0, 1 };

        Assert.That(actual, Is.EqualTo(output));
    }
    [Test]
    public void Test_TwoSum2()
    {
        var input = new List<int>() { 3, 2, 4 };
        var target = 6;

        var actual = InterviewPractice.TwoSum(input, target);

        var output = new List<int>() { 1, 2 };

        Assert.That(actual, Is.EqualTo(output));
    }

    [TestCase("leetcode", 0)]
    [TestCase("loveleetcode", 2)]
    [TestCase("aabb", -1)]
    public void Test_FirstNonrepeatingChar(string input, int output)
    {
        var actual = InterviewPractice.FirstNonrepeatingChar(input);

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_PlusOne()
    {
        var input = new List<int>() { 1, 2, 3 };

        var actual = InterviewPractice.PlusOne(input);

        var output = new List<int>() { 1, 2, 4 };

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_PlusOne2()
    {
        var input = new List<int>() {4,3,2,1};

        var actual = InterviewPractice.PlusOne(input);

        var output = new List<int>() {4,3,2,2};

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_PlusOne3()
    {
        var input = new List<int>() {9};

        var actual = InterviewPractice.PlusOne(input);

        var output = new List<int>() {1,0};

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_SingleNumber()
    {
        var input = new List<int>() { 2, 2, 1 };

        var actual = InterviewPractice.SingleNumber(input);

        var output = 1;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_SingleNumber2()
    {
        var input = new List<int>() { 4, 1, 2, 1, 2 };

        var actual = InterviewPractice.SingleNumber(input);

        var output = 4;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_SingleNumber3()
    {
        var input = new List<int>() { 1 };

        var actual = InterviewPractice.SingleNumber(input);

        var output = 1;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ContainsDuplicates()
    {
        var input = new List<int>() { 1, 2, 3, 1 };

        var actual = InterviewPractice.ContainsDuplicates(input);

        var output = true;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ContainsDuplicates2()
    {
        var input = new List<int>() { 1, 2, 3, 4 };

        var actual = InterviewPractice.ContainsDuplicates(input);

        var output = false;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ContainsDuplicates3()
    {
        var input = new List<int>() { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        var actual = InterviewPractice.ContainsDuplicates(input);

        var output = true;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_LongestCommonPrefix(){
        var input = new List<string>() {"flower","flow","flight"};

        var actual = InterviewPractice.LongestCommonPrefix(input);

        var output = "fl";

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_LongestCommonPrefix2()
    {
        var input = new List<string>() {"dog","racecar","car"};

        var actual = InterviewPractice.LongestCommonPrefix(input);

        var output = "";

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_LongestCommonPrefix3()
    {
        var input = new List<string>() {"roger","rotate","row"};

        var actual = InterviewPractice.LongestCommonPrefix(input);

        var output = "ro";

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_LongestCommonPrefix4()
    {
        var input = new List<string>() {"gloat","glow","gloom",};

        var actual = InterviewPractice.LongestCommonPrefix(input);

        var output = "glo";

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ValidPalindrome()
    {
        var input = "A man, a plan, a canal: Panama";

        var actual = InterviewPractice.ValidPalindrome(input);

        var output = true;

        Assert.That(actual, Is.EqualTo(output));
    }

    [Test]
    public void Test_ValidPalindrome2()
    {
        var input = "race a car";

        var actual = InterviewPractice.ValidPalindrome(input);

        var output = false;

        Assert.That(actual, Is.EqualTo(output));
    }
}