using System;
using System.Text;

namespace C__Practice;

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
        var returnSeed = new List<int>();
        var loopLength = inputList.Count - 1;
        for (int i = 0; i < loopLength; i++)
        {
            for (int j = i + 1; j < loopLength; j++)
            {
                if(inputList[i] + inputList[j] == inputTarget){
                    returnSeed.Add(i);
                    returnSeed.Add(j);
                }
            }
        }
        return returnSeed;
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
       var loopLength = inputNums.Count - 1;
       for (int i = loopLength; i >= 0; i--)
       {
            if(inputNums[i] == 9){
                inputNums[i] = 0;
            } else {
                inputNums[i]++;
                return inputNums;
            }
       }
       var carriedOne = new List<int>(){1};
       return carriedOne.Concat(inputNums);
    }

    public static int SingleNumber(List<int> input)
    {
        var numsCount = new Dictionary<int, int>();

        foreach (var num in input)
        {
            if(numsCount.ContainsKey(num)){
                numsCount[num]++;
            } else {
                numsCount[num] = 1;
            }
        }

        var retInt = 0;

        foreach (var key in numsCount)
        {
            if(key.Value == 1){
                retInt = key.Key;
                return retInt;
            }
        }

        return retInt;
    }

    public static bool ContainsDuplicates(List<int> numsList)
    {
        var countDict = new Dictionary<int, int>();
        var loopLength = numsList.Count - 1;
        foreach (var element in numsList)
        {
             if(countDict.ContainsKey(element)){
                countDict[element]++;
            } else {
                countDict[element] = 1;
            }
        }

        var returnBool = false;

        foreach (var keyValuePair in countDict)
        {
            if(keyValuePair.Value >= 2){
                returnBool = true;
                return returnBool;
            }
        }
        return returnBool;
    }

    public static string LongestCommonPrefix(List<string> strs) //Need to practice this one
    { // why is this O(n)? because it loops through the input only once. it checks each word based off the first word.

        if (strs.Count == 1)
        { // edge case of input being 1 index, return the index.
            return strs[0];
        }

        var prefixString = "";

        if(strs.Count == 1 || strs == null){
            return prefixString;
        }

        var firstWord = strs[0];
        var loopLength = strs[0].Length - 1;

        for (int i = 0; i < loopLength; i++)
        {
            foreach (var str in strs)
            {
                if( i > firstWord.Length){
                    return prefixString;
                } else if(firstWord[i] != str[i]){
                    return prefixString;
                }
            }
            prefixString += firstWord[i];
        }
        return prefixString;
    }

    public static bool ValidPalindrome(string inputString)
    {
        
        if (inputString.Length == 1 && char.IsLetterOrDigit(inputString[0])) // edge case, return true if the input is only 1 letter or digit
        {
            return true;
        }

        var transformedInput = inputString.ToLower().ToList();
        StringBuilder palindromeCheck = new StringBuilder();

        foreach (var element in transformedInput)
        {
            if(char.IsLetterOrDigit(element)){
                palindromeCheck.Append(element);
            }
        }

        var returnBool = true;
        var rightPointer = palindromeCheck.Length - 1;
        var leftPointer = 0;

        while(rightPointer - leftPointer > 0){
            if(palindromeCheck[rightPointer] != palindromeCheck[leftPointer]){
                returnBool = false;
                return returnBool;
            }
            rightPointer -= 1;
            leftPointer += 1;
        }
        return returnBool;
    }
}