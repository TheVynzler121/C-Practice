namespace C__Practice;


// List<T> is-a IEnumerable<T>
// Dictionary<T, U> is-a IEnumerable<T>
public class CompundSequenceAbstractions
{
    public static IEnumerable<int> AddTenIfBigEnough(IEnumerable<int> numbList)
    {
        
        var outputList = new List<int>();
        foreach (var x in numbList)
        {
            if(x > 3)
            {
                outputList.Add(x + 10);
            }
        }
        return outputList;
    }

    public static string Capitalize(string x) {
        return x[0].ToString().ToUpper() + x.Substring(1);
    }

    public static IEnumerable<string> NamesStartingWithR(IEnumerable<string> nameList)
    {
        
        var outputList = new List<string>();
        foreach (var x in nameList)
        {
            if(x[0] == 'r')
            {
                outputList.Add(Capitalize(x));
            }
        }
        return outputList;
    }

    public static IEnumerable<int> ReturnNumbersGreaterThanAverage(IEnumerable<int> numbList)
    {
        // average add them all together and divide by the total count
        // var numbAverage = numbList.Average();
        // return numbList.Where(x => x > numbAverage);

        var sum = 0;
        foreach (var x in numbList)
        {
            sum = sum + x;
        }

        var average = sum/numbList.Count();

        var outputList = new List<int>();
        foreach (var x in numbList)
        {
            if(x > average)
            {
                outputList.Add(x);
            }
        }
        return outputList;
    }
}