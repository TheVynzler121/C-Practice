namespace C__Practice;

public class GameItem
{
    public string Name { get; set; }
    public int GoldCost { get; set; }
}

public class SequenceAbstractions
{
    public static int SumNumbers(List<int> numbs)
    {
        // var sumOfNumbs = 0;
        // foreach (var numb in numbs)
        // {
        //     sumOfNumbs = sumOfNumbs + numb;
        // }
        // return sumOfNumbs;
        return numbs.Aggregate(0, (sumOfNumbs, numb) => sumOfNumbs += numb);
    }

    public static List<int> GetGoldCosts(List<GameItem> costs)
    {
        return costs.Select(item => item.GoldCost).ToList();
    }

    public static int TotalCost(List<GameItem> itemList)
    {
        // var totalGoldCost = 0;
        // foreach (var item in items)
        // {
        //     totalGoldCost = totalGoldCost + item.GoldCost;
        // }
        // return totalGoldCost;
        return itemList.Aggregate(0, (goldSeed, item) => goldSeed += item.GoldCost);
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

    public static IEnumerable<string> WordsLongEnough(List<string> wordList)
    {
        // return words.Where(word => word.Length > 4).ToList();
        // var wordsLongEnough = new List<string>();
        // foreach (var word in words)
        // {
        //     if (word.Length > 4)
        //     {
        //         wordsLongEnough.Add(word);
        //     }
        // }
        // return wordsLongEnough;
        return wordList.Aggregate(new List<string>(), (wordsLongerThanFour, word) => {
            if (word.Length > 4) {
                wordsLongerThanFour.Add(word);
            }
            return wordsLongerThanFour;
        });
    }

    public static List<string> WordsStartWithS(List<string> wordList)
    {
        return wordList.Where(word => word[0] == 's').ToList();
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

    public static List<int> NumbersSmallerThan5(List<int> inputList)
    {
        return inputList.Where(numb => numb < 5).ToList();
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

    public static List<int> SumOfSquares(List<int> inputList)
    {
        // var xs = new List<int>();
        // foreach (var y in ys) {
        //     xs.Add(y * y * 2);
        // }

        // return xs;
        return inputList.Aggregate(new List<int>(), (seedList, number) => {seedList.Add(number * number * 2); return seedList;});
    }

    public static IEnumerable<string> IntsToStrings(List<int> inputString)
    {
        return inputString.Select(number => number.ToString());
    }

    public static IEnumerable<string> FirstLetterCapitalized(List<string> inputList)
    {
        return inputList.Select(word => word[0].ToString().ToUpper());
    }

    public static int CountStrings(List<string> names)
    {
        // var x = 0;
        // foreach (var name in names)
        // {
        //     x++;
        // }
        // return x;
        return names.Aggregate(0, (seed, name) => seed += 1); // why does ++ not work here?
    }

    public static string MergeStrings(List<string> words)
    {
        // var outputString = "";
        // foreach (var word in words)
        // {
        //     outputString = outputString + word;
        // }
        // return outputString;
        return words.Aggregate("", (wordSeed, word) => wordSeed += word);
    }

    public static string FirstLetters(List<string> stringList)
    {
        // var x = "";
        // foreach (var word in inputString)
        // {
        //     x = x + word[0];
        // }
        // return x;
        return stringList.Aggregate("", (stringSeed, wordInList) => stringSeed += wordInList[0]);
    }

    public static int CountWordLengths(List<string> wordList)
    {
        // var countedLengths = 0;
        // foreach (var word in words)
        // {
        //     countedLengths = countedLengths + word.Length;
        // }
        // return countedLengths;
        return wordList.Aggregate(0, (countSeed, word) => countSeed += word.Length);
    }

    public static bool AreAllMoreThanThreeLength(List<string> wordList)
    {
        // foreach (var word in words)
        // {
        //     if (word.Length < 3)
        //     {
        //         return false;
        //     }
        // }
        // return true;
        return wordList.Aggregate(true, (seed, word) =>
        {
            if (word.Length < 3)
            {
                seed = false;
                return seed;
            }
            return seed;
        });
    }

    public static int AddEmUp(List<int> inputList)
    {
        // var ret = 0;
        // foreach (var numb in inputList)
        // {
        //     ret += numb;
        // }
        // return ret;
        return inputList.Aggregate(0, (seed, number) => { return seed += number; });
        // 0, 5  => 0 + 5
        // 5, 7  => 5 + 7
        // 12,10 => 12 + 10
        // 22, 3 => 22 + 3
        // 25
    }

    public static bool IsEven(int x)
    {
        return x % 2 == 0;
    }

    public static int AddEvenUp(List<int> inputList)
    {
        // var seed = 0;
        // foreach (var number in inputList)
        // {
        //     if(IsEven(number))
        //     {
        //         seed += number;
        //     }
        // }
        // return seed;
        return inputList.Aggregate(0, (seed, number) =>
        {
            if (IsEven(number))
            {
                seed += number;
            }

            return seed;
        });
    }

    public static int SumOfNumbersLargerThanSeven(List<int> inputNumbs)
    {
        // var totalSum = 0;
        // foreach (var numb in inputNumbs)
        // {
        //     if (numb > 7)
        //     {
        //         totalSum = totalSum + numb;
        //     }
        // }
        // return totalSum;
        return inputNumbs.Aggregate(0, (totalSum, number) =>
        {
            if (number > 7)
            {
                totalSum += number;
            }
            return totalSum;
        });
    } 
}