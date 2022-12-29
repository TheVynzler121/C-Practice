namespace C__Practice;

public class GameItem {
    public string Name { get;set;}
    public int GoldCost { get;set;}
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

    public static List<int> GetGoldCosts(List<GameItem> costs)
    {
        return costs.Select(cost => cost.GoldCost).ToList();
    }

    public static int TotalCost(List<GameItem> items)
    {
        var cost = 0;
        foreach (var item in items)
        {
            cost = cost + item.GoldCost;
        }
        return cost;
    }

    public static List<int> NumbersUnder500(List<int> ys) {
        return ys.Where(y => y < 500).ToList();
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
            if(word.Length > 4)
            {
                wordsLongEnough.Add(word);
            }
        }
        return wordsLongEnough;
    }

    public static List<string> WordsStartWithS(List<string> words)
    {
        return words.Where(word => word[0] == 's').ToList();
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

    public static List<int> NumbersSmallerThan5(List<int> numbList)
    {
        return numbList.Where(numb => numb < 5).ToList();
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
        // 1,2,3,4,5,6
        // 1,2,3,4,5,6 => 11, 12, 13, 14, 15,16
        // 1 => 11
        return ys.Select(y => y + 10).ToList();
    }

    public static List<int> CountDigits(List<int> numbs)
    {
        var countedList = new List<int>();
        foreach (var numb in numbs)
        {
            countedList.Add(numb.ToString().Length);
        }
        return countedList;
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

    public static List<string> IntsToStrings(List<int> ys)
    {
       return ys.Select(y => y.ToString()).ToList();
    }

    public static List<string> FirstLetterCapitalized(List<string> ys)
    {
        return ys.Select(y => y[0].ToString().ToUpper()).ToList();
    }

    public static int CountStrings(List<string> names)
    {
        var countedStrings = 0;
        foreach (var name in names)
        {
            countedStrings++;
        }
        return countedStrings;
    }
    
    public static string MergeStrings(List<string> words)
    {
        var merge = "";

        foreach (var word in words)
        {
            merge = merge + word;
        }
        return merge;
    }
    public static string FirstLetters(List<string> words)
    {
        var firstLettersString = "";
        foreach (var word in words)
        {
            firstLettersString = firstLettersString + word[0];
        }
        return firstLettersString;
    }

    public static int CountWordLengths(List<string> words)
    {
        var seed = 0;
        foreach (var word in words)
        {
            seed = seed + word.Length;
        }
        return seed;
    }

    public static bool AreAllMoreThanThreeLength(List<string> words)
    {
        var ret = true;
        foreach (var word in words)
        {
            if (word.Length < 3)
            {
                return false;
            }
        }
        return ret;
    }
}