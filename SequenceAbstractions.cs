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
        return numbs.Aggregate(0, (sumOfNumbs, numb) => sumOfNumbs += numb);
    }

    public static List<int> GetGoldCosts(List<GameItem> costs)
    {
        return costs.Select(item => item.GoldCost).ToList();
    }

    public static int TotalCost(List<GameItem> itemList)
    {
        return itemList.Aggregate(0, (goldSeed, item) => goldSeed += item.GoldCost);
    }

    public static List<int> NumbersUnder500(List<int> numbList)
    {
        return numbList.Where(numb => numb < 500).ToList();     
    }

    public static IEnumerable<string> WordsLongEnough(List<string> wordList)
    {       
        return wordList.Aggregate(new List<string>(), (wordsLongerThanFour, word) =>
        {
            if (word.Length > 4)
            {
                wordsLongerThanFour.Add(word);
            }
            return wordsLongerThanFour;
        });
    }

    public static List<string> WordsStartWithS(List<string> wordList)
    {
        var seedForList = new List<string>();
        foreach (var word in wordList)
        {
            if(word[0] == 's'){
                seedForList.Add(word);
            }
        }
        return seedForList;
        // return wordList.Where(word => word[0] == 's').ToList();       
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
    }

    public static List<int> SumOfSquares(List<int> inputList)
    {       
        return inputList.Aggregate(new List<int>(), (seedForList, numberInList) => 
        {seedForList.Add(numberInList * numberInList * 2); 
        return seedForList;
        });
    }

    public static IEnumerable<string> IntsToStrings(List<int> inputString)
    {
        return inputString.Select(number => number.ToString());
    }

    public static List<string> FirstLetterCapitalized(List<string> wordList)
    {
        return wordList.Select(word => word[0].ToString().ToUpper()).ToList();
    }

    public static int CountStrings(List<string> names)
    {
        
        return names.Aggregate(0, (seed, name) => seed += 1); // why does ++ not work here?
    }

    public static string MergeStrings(List<string> wordList)
    {
        return wordList.Aggregate("", (stringSeed, word) => stringSeed += word);
    }

    public static string FirstLetters(List<string> wordList)
    {
        var letterSeed = "";
        foreach (var word in wordList)
        {
            letterSeed += word[0];
        }
        return letterSeed;
    }

    public static int CountWordLengths(List<string> inputList)
    {
        var seedInt = 0;
        foreach (var word in inputList)
        {
            seedInt += word.Length;
        }
        return seedInt;
    }

    public static bool AreAllMoreThanThreeLength(List<string> wordList)
    {       
        return wordList.Aggregate(true, (seedBool, wordInList) =>
        {
            if (wordInList.Length < 3)
            {
                seedBool = false;
                return seedBool;
            }
            return seedBool;
        });
    }

    public static int AddEmUp(List<int> numberList)
    {        
        return numberList.Aggregate(0, (intSeed, number) => number += intSeed);      
    }

    public static bool IsEven(int x)
    {
        return x % 2 == 0;
    }

    public static int AddEvenUp(List<int> inputList)
    {      
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
        var seedInt = 0;
        foreach (var numb in inputNumbs)
        {
            if(numb >= 7){
                seedInt += numb;
            }
        }
        return seedInt;
    }
}