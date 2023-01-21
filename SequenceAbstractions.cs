namespace C__Practice;

public class GameItem
{
    public string Name { get; set; }
    public int GoldCost { get; set; }
}

public class SequenceAbstraction
{
    public static int SumNumbers(List<int> numbs)
    {
        var sumOfNumbs = 0;
        foreach (var numb in numbs)
        {
            sumOfNumbs = sumOfNumbs + numb;
        }
        return sumOfNumbs;
    }

    public static IEnumerable<int> GetGoldCosts(List<GameItem> costs)
    {
        return costs.Select(x => x.GoldCost);
    }

    public static int TotalCost(List<GameItem> items)
    {
        var totalGoldCost = 0;
        foreach (var item in items)
        {
            totalGoldCost = totalGoldCost + item.GoldCost;
        }
        return totalGoldCost;
    }

    public static List<int> NumbersUnder500(List<int> numbList)
    {

        return numbList.Where(numb => numb < 500).ToList();
        // var xs = new List<int>();
        // foreach (var y in ys)
        // {
        //     if(y < 500) {
        //         xs.Add(y);
        //     }
        // }

        // return xs;
    }

    public static List<string> WordsLongEnough(List<string> words)
    {
        // return words.Where(word => word.Length > 4).ToList();
        var wordsLongEnough = new List<string>();
        foreach (var word in words)
        {
            if (word.Length > 4)
            {
                wordsLongEnough.Add(word);
            }
        }
        return wordsLongEnough;
    }

    public static List<string> WordsStartWithS(List<string> words)
    {
        return words.Where(words => words[0] == 's').ToList();
        // var sWords = new List<string>();
        // foreach (var word in words)
        // {
        //     if(word[0] == 's')
        //     {
        //         sWords.Add(word);
        //     }
        // }
        // return sWords;
    }

    public static IEnumerable<int> NumbersSmallerThan5(List<int> numbList)
    {
       return numbList.Where(numb => numb < 5);
    }

    /*

    // reduce "shape"

    public static U NAME<T, U>(List<T> ys) {
        var x = U empty;
        foreach (var y in ys)
        {
             x = CHANGE Y and add to x; 
        }

        return x;
    }

    // filter "shape"

    public static List<T> NAME<T>(List<T> ys) {
        var xs = new List<T>();
        foreach (var y in ys)
        {
            if(CONDITION HERE) {
                xs.Add(y);
            }
        }

        return xs;
    }



    // map "shape"

    public static List<U> NAME(List<T> ys)
    {
        var xs = new List<U>();
        foreach(var y in ys) {
            xs.Add(DO SOMETHING TO Y);
        }
        return xs;
    }
    */

    public static List<int> AddsTen(List<int> ys)
    {
        return ys.Select(ys => ys + 10).ToList();       
    }

    public static List<int> CountDigits(List<int> numbs)
    {
        return numbs.Select(numb => numb.ToString().Length).ToList();
        // var countedList = new List<int>();
        // foreach (var numb in numbs)
        // {
        //     countedList.Add(numb.ToString().Length);
        // }
        // return countedList;
    }

    public static List<int> SumOfSquares(List<int> ys)
    {
        var xs = new List<int>();
        foreach (var y in ys)
        {
            xs.Add((y * y) * 2);
        }
        return xs;
    }

    public static IEnumerable<string> IntsToStrings(List<int> inputString)
    {
        return inputString.Select(x => x.ToString());
    }

    public static IEnumerable<string> FirstLetterCapitalized(List<string> inputList)
    {
        return inputList.Select(x => x[0].ToString().ToUpper());
    }

    public static int CountStrings(List<string> names)
    {
        var x = 0;
        foreach (var name in names)
        {
            x++;
        }
        return x; 
    }

    public static string MergeStrings(List<string> words)
    {
        var outputString = "";
        foreach (var word in words)
        {
            outputString = outputString + word;
        }
        return outputString;
    }

    public static string FirstLetters(List<string> inputString)
    {
        var x = "";
        foreach (var word in inputString)
        {
            x = x + word[0];
        }
        return x;
    }

    public static int CountWordLengths(List<string> words)
    {
        var lengthSum = 0;
        foreach (var word in words)
        {
            lengthSum = lengthSum + word.Length;
        }
        return lengthSum;
    }

    public static bool AreAllMoreThanThreeLength(List<string> words)
    {       
       foreach (var word in words)
       {
            if(word.Length < 3)
            {
                return false;
            }
       }
       return true;
    }
}