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
        var allCharacterPositions = new Dictionary<char, List<int>>();
        for (int i = 0; i < inputString.Length; i++)
        {
            var character = inputString[i];
            if (!allCharacterPositions.ContainsKey(character))
            {
                var indexes = new List<int>() { i }; // {count: 1, firstIndex: i}
                allCharacterPositions.Add(character, indexes);
            }
            else
            {
                var indexes = allCharacterPositions[character]; // record.count++ 
                indexes.Add(-1);
            }
        }

        PrintDictionary<char, int>(allCharacterPositions);

        for (int i = 0; i < inputString.Length; i++)
        {
            var character = inputString[i];
            var uniqueCharacterPositions = allCharacterPositions[character];
            if (uniqueCharacterPositions.Count == 1)
            {
                return uniqueCharacterPositions[0];
            }
        }
        return -1;
    }

    public static IEnumerable<int> PlusOne(List<int> inputNums)
    {
        var loopCount = inputNums.Count() - 1;
        for (int i = loopCount; i >= 0; i--)
        {
            if(inputNums[i] == 9){
                inputNums[i] = 0;
            } else {
                inputNums[i]++;
                return inputNums;
            }
        }
        var newOne = new List<int>() {1};
        return newOne.Concat(inputNums);
    }

    public static int SingleNumber(List<int> inputList)
    {
        return inputList.GroupBy(x => x)
        .Where(x => x.Count() == 1)
        .Select(x => x.Key)
        .First();
        // var countingDict = new Dictionary<int, int>();

        // foreach (var num in input)
        // {
        //     if (!countingDict.ContainsKey(num))
        //     {
        //         countingDict[num] = 1;
        //     }
        //     else
        //     {
        //         countingDict[num]++;
        //     }
        // }

        // var returnInt = 0;

        // foreach (var keyAndValue in countingDict)
        // {
        //     if (keyAndValue.Value == 1)
        //     {
        //         returnInt = keyAndValue.Key;
        //         return returnInt;
        //     }
        // }

        // return returnInt;
    }

    public static bool ContainsDuplicates(List<int> numsList)
    {
        return numsList.GroupBy(x => x)
        .Any(x => x.Count() > 1);
        // var countDict = new Dictionary<int, int>();
        // foreach (var num in numsList)
        // {
        //     if(!countDict.ContainsKey(num)){
        //         countDict[num] = 1;
        //     } else {
        //         countDict[num]++;
        //     }
        // }

        // foreach (var keyValuePair in countDict)
        // {
        //     if(keyValuePair.Value >= 2){
        //         return true;
        //     }
        // }
        // return false;
    }

    public static string LongestCommonPrefix(List<string> strs) 
    { 
        var shortest = strs.OrderBy(str => str.Length).First();

        for (int i = 0; i < shortest.Length; i++)
        {
            if(strs.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
        }

        return shortest;

        // var prefixCheck = "";
        // var firstIndex = strs[0];
        // for (int i = 0; i < firstIndex.Length; i++)
        // {
        //     foreach (var word in strs)
        //     {
        //         if(i > firstIndex[i]){
        //             return prefixCheck;
        //         } else if(firstIndex[i] != word[i]){
        //             return prefixCheck;
        //         }
        //     }
        //     prefixCheck += firstIndex[i];
        // }
        // return prefixCheck;
    }

    public static bool ValidPalindrome(string inputString)
    {
        var palinSeed = inputString.ToLower()
        .Where(x => char.IsLetterOrDigit(x));
        
        return palinSeed.Reverse().SequenceEqual(palinSeed);
    }
}