namespace C__Practice;


 public enum NumbersList{
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
    }

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

   

    public static NumbersList extractNumber(string numberString){
        var charToNumber = new Dictionary<char, NumbersList> {
            {'1', NumbersList.One},
            {'2', NumbersList.Two},
            {'3', NumbersList.Three},
            {'4', NumbersList.Four}
        };
        return charToNumber[numberString[0]];
    }

}