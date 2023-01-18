namespace C__Practice;


// List<T> is-a IEnumerable<T>
// Dictionary<T, U> is-a IEnumerable<T>
public class CompundSequenceAbstractions
{
    public static IEnumerable<int> AddTenIfBigEnough(IEnumerable<int> numbList)
    {
        return numbList.Where(numb => numb > 3).Select(numb => numb + 10);
        
    }

    public static int SumOfNumbersLargerThanSeven(List<int> inputNumbs)
    {
        var totalSum = 0;
        foreach (var numb in inputNumbs)
        {
            if (numb > 7)
            {
                totalSum = totalSum + numb;
            }
        }
        return totalSum;
    }

    public static string Capitalize(string x)
    {
        return x[0].ToString().ToUpper() + x.Substring(1);
    }

    public static IEnumerable<string> NamesStartingWithR(IEnumerable<string> nameList)
    {

        var outputList = new List<string>();
        foreach (var x in nameList)
        {
            if (x[0] == 'r')
            {
                outputList.Add(Capitalize(x));
            }
        }
        return outputList;
    }

    // LINQ - helper functions for sequence abstractions
    // Select, Where, Count, Average
    public static IEnumerable<int> ReturnNumbersGreaterThanAverage(IEnumerable<int> numbList)
    {
        var numbAverage = numbList.Average();
        return numbList.Where(numb => numb > numbAverage);
    }

    // List<T> is-a IEnumerable<T>
    public static IEnumerable<string> ItemsICanAfford(IEnumerable<GameItem> items, int budget)
    {
        return items.Where(item => item.GoldCost < budget).Select(item => item.Name);
    }

    public static string GetFirstWord(string sentence)
    {
        return sentence.Split(' ')[0];
    }

    public static IEnumerable<string> FirstWordIfStartsWith(IEnumerable<GameItem> items, char firstLetter)
    {
        return items.Where(item => item.Name[0] == firstLetter).Select(item => GetFirstWord(item.Name));
    }

    public static IEnumerable<string> NumbersLargerThanFiveToString(List<int> numbList)
    {
        return numbList.Where(numb => numb > 5).Select(numb => numb.ToString());
    }
}
