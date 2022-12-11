namespace C__Practice;

public class Arith
{
    public static int add(int x, int y)
    {
        return x + y;
    }

    public static int subtract(int x, int y)
    {
        return x - y;
    }

    public static Dictionary<string, int> countNumbers(string[] numbersToCount){
        var counts = new Dictionary<string, int>{
            {"1", 0},
            {"2", 0},
            {"3", 0},
        };

        foreach (var number in numbersToCount)
        {
            counts[number]++;
        }

        return counts;
    }

}