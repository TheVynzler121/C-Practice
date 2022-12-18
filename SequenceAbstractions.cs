namespace C__Practice;

public class SequenceAbstraction
{
    public static int SumNumbers(List<int> ys) // 1,2,3,4
    {
        var x = 0; // use a variable on the outside to remember something
        foreach (var y in ys)
        {
            x = x + y;
        }
        return x;
    }
    
    public static string MergeStrings(List<string> ys)
    {
        var x = ""; // seed
        foreach (var y in ys)
        {
            x = x + y;
        }

        return x;
    }

    public static int CountStrings(List<string> names)
    {
        var nameCount = 0;
        foreach (var name in names)
        {
            nameCount++;
        }
        return nameCount;
    }

    public static string FirstLetters(List<string> words)
    {
        var x = "";
        foreach (var word in words)
        {
            x = x + word[0];
        }

        return x;
    }

    public static int CountWordLengths(List<string> words)
    {
        var x = 0;
        foreach (var word in words)
        {
            x = x + word.Length;
        }
        return x;
    }

    public static bool AreAllMoreThanThreeLength(List<string> words)
    {

        foreach (var word in words)
        {
            if (word.Length < 3)
            {
                return false;
            }
        }
        return true;
    }
}