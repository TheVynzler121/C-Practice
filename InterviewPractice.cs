using System;
using System.Text;
using System.Linq;

namespace C__Practice;

public class Weapon
{
    public string name;
    public string weaponType;
    public int damage;

    public Weapon(string name, string weaponType, int damage)
    {
        this.name = name;
        this.weaponType = weaponType;
        this.damage = damage;
    }
}

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input)
    {
        var prevChar = ' ';
        foreach (var character in input)
        {
            if (character == prevChar)
            {
                return true;
            }
            prevChar = character;
        }
        return false;
    }

    public static IEnumerable<string> ReverseString(List<string> inputList)
    {
        var returnList = new List<string>();
        foreach (var character in inputList)
        {
            returnList.Insert(0, character);
        }
        return returnList;
    }

    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget)
    {
        var seedList = new List<int>();
        for (int i = 0; i < inputList.Count; i++)
        {
            for (int j = i + 1; j < inputList.Count; j++)
            {
                if (inputList[i] + inputList[j] == inputTarget)
                {
                    seedList.Add(i);
                    seedList.Add(j);
                }
            }
        }
        return seedList;
    }

    public static void PrintList<T>(IEnumerable<T> input)
    {
        Console.WriteLine("[");
        foreach (var x in input)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("]");
    }

    public static void PrintDictionary<T, U>(Dictionary<T, List<U>> input)
    {
        Console.WriteLine("[");
        foreach (var x in input)
        {
            Console.WriteLine($"{x.Key}: ");
            Console.WriteLine("");
            PrintList(x.Value);
        }

        Console.WriteLine("]");
    }

    /* 
    {
        l: [0, 4],
        o: [1, 9],
        v: [2],
        e: [3, 5, 6, 11],
        t: [7],
        c: [8],
        d: [10]
    }    
    {
        l: {count: 2, firstIndex: 0},
        o: {count: 2, firstIndex: 1},
        v: {count: 1, firstIndex: 2},
        e: {count: 4, firstIndex: 3},
        t: [7] Count=1,
        c: [8] Count=1,
        d: [10] Count=1,
    }    
    */
    public static int FirstNonrepeatingChar(string inputString) //Need to practice this one
    {
        //int seed
        //group the input by itself, order it by its count, take the first one.
        //var storing the count of each key in grouped list
        //if the count is 1, set answer to the index of the grouped list key
        //otherwise, set answer to -1

        var retInt = 0;
        var grouped = inputString.GroupBy(i => i)
                                .OrderBy(i => i.Count())
                                .First();
        var groupKeys = inputString.Where(i => i == grouped.Key).Count();
        if(groupKeys == 1){
            retInt = inputString.IndexOf(grouped.Key);
        } else {
            retInt = -1;
        }
        return retInt;
    }

    public static IEnumerable<int> PlusOne(List<int> inputNums)
    {
        for (int i = inputNums.Count - 1; i >= 0; i--)
        {
            if(inputNums[i] == 9){
                inputNums[i] = 0;
            } else {
                inputNums[i]++;
                return inputNums;
            }
        }
        var firstOne = new List<int>() {1};
        return firstOne.Concat(inputNums);
    }

    public static int SingleNumber(List<int> input)
    {
        return input.GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key)
                    .First();
       
    }

    public static bool ContainsDuplicates(List<int> numsList)
    {
        return numsList.GroupBy(num => num)
                .Any(num => num.Count() >= 2);
    }

    public static string LongestCommonPrefix(List<string> strs) 
    { 
        var shortWord = strs.OrderBy(str => str.Length).First();

        for (int i = 0; i < shortWord.Length; i++)
        {
            if(strs.Select(str => str[i]).Distinct().Count() > 1){
                return shortWord[..i];
            }
        }
        return shortWord;
    }

    public static bool ValidPalindrome(string inputString)
    {
        //change the input to all lowercase, then filter out everything that isnt a letter or digit
        //return true if the palinCheck is the same sequence in reverse order

        var palindromeSeed = inputString.ToLower().Where(x => char.IsLetterOrDigit(x));
        return palindromeSeed.Reverse().SequenceEqual(palindromeSeed);
    }
}