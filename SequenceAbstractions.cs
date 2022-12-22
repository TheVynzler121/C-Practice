namespace C__Practice;

public class SequenceAbstraction
{
    public static int SumNumbers(List<int> numbs)
    {
        var x = 0;
        foreach (var numb in numbs)
        {
            x = x + numb;
        }    
        return x;
    }

    public static int CountStrings(List<string> names)
    {
        var stringCount = 0;

        foreach (var name in names)
        {
            stringCount++;
        }
        return stringCount;
    }
    
    public static string MergeStrings(List<string> words)
    {
        var x = "";
        foreach (var word in words)
        {
            x = x + word;
        }
        return x;
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
        var lengthCount = 0;

        foreach (var word in words)
        {
            lengthCount = lengthCount + word.Length;
        }
        return lengthCount;
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