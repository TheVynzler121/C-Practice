namespace C__Practice;


// List<T> is-a IEnumerable<T>
// Dictionary<T, U> is-a IEnumerable<T>
public class CompundSequenceAbstractions
{
    public static IEnumerable<int> AddTenIfBigEnough(IEnumerable<int> numbList)
    {
        return numbList.Where(x => x > 3).Select(x => x + 10);
        // var outputList = new List<int>();
        // foreach (var x in numbList)
        // {
        //     if (x > 3)
        //     {
        //         outputList.Add(x + 10);
        //     }
        // }
        // return outputList;
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
        var average = numbList.Average();
        return numbList.Where(x => x > average);
    }

    // List<T> is-a IEnumerable<T>
    public static IEnumerable<string> ItemsICanAfford(IEnumerable<GameItem> items, int budget)
    {
        return items.Where(x => x.GoldCost < budget).Select(x => x.Name);
    }

    public static string GetFirstWord(string sentence)
    {
        return sentence.Split(' ')[0];
    }

    public static IEnumerable<string> FirstWordIfStartsWith(IEnumerable<GameItem> items, char firstLetter)
    {
        return items.Where(x => x.Name[0] == firstLetter).Select(x => GetFirstWord(x.Name));
    }
}
