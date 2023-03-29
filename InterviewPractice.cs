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
        var retList = new List<int>();
        var loopLength = inputList.Count - 1;
        for (int i = 0; i < loopLength; i++)
        {
            for (int j = i + 1; j < loopLength; j++)
            {
                if(inputList[i] + inputList[j] == inputTarget){
                    retList.Add(i);
                    retList.Add(j);
                }
            }
        }
        return retList;
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
        var startingInt = inputNums.Count - 1;
        for (int i = startingInt; i >= 0; i--)
        {
            if(inputNums[i] == 9){
                inputNums[i] = 0;
            } else {
                inputNums[i]++;
                return inputNums;
            }
        }
        var firstOne = new List<int>(){1};
        return firstOne.Concat(inputNums);
    }

    public static int SingleNumber(List<int> input)
    {
        var loopLength = input.Count;
        var numCount = new Dictionary<int, int>();
        for (int i = 0; i < loopLength; i++)
        {
            var currentNum = input[i];
            if(!numCount.ContainsKey(currentNum)){
                numCount[currentNum] = 1;
            } else {
                numCount[currentNum]++;
            }
        } 

        var retInt = 0;
        foreach (var keyValuePair in numCount)
        {
            if(keyValuePair.Value == 1){
                retInt = keyValuePair.Key;
            }
        }
        return retInt;
    }

    public static bool ContainsDuplicates(List<int> numsList)
    {
        var countedNums = new Dictionary<int, int>();
        foreach (var num in numsList)
        {
            if(countedNums.ContainsKey(num)){
                countedNums[num]++;
            } else {
                countedNums[num] = 1;
            }
        }
        var returnBool = false;
        foreach (var keyAndValue in countedNums)
        {
            if(keyAndValue.Value >= 2){
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

        if (strs == null || strs.Count == 0)
        { // another edge case for if the input is empty, return an empty string.
            return prefixString;
        }

        for (int i = 0; i < strs[0].Length; i++) // loop for the length of the first word
        {
            foreach (var str in strs) // for each word in the input
            {
                if (i > str.Length)
                { // if the index is greater than the length of the current word
                    return prefixString; // return the prefixString
                }
                else if (strs[0][i] != str[i])
                { // else if the char index of the first word is not equal to the current words char index
                    return prefixString; //return the prefixString
                }
            }
            prefixString += strs[0][i]; // add the first words char index to the prefixstring
        }
        return prefixString;
    }

    public static bool ValidPalindrome(string inputString)
    {
        
        if (inputString.Length == 1 && char.IsLetterOrDigit(inputString[0])) // edge case, return true if the input is only 1 letter or digit
        {
            return true;
        }

        var stringToLower = inputString.ToLower().ToList();
        StringBuilder palinString = new StringBuilder();

        foreach (var element in stringToLower)
        {
            if(char.IsLetterOrDigit(element)){
                palinString.Append(element);
            }
        }

        var pointerRight = palinString.Length - 1;
        var pointerLeft = 0;
        var retBool = true;
        while(pointerRight - pointerLeft > 0){
            if(palinString[pointerRight] != palinString[pointerLeft]){
                retBool = false;
                return retBool;
            }
            pointerRight -= 1;
            pointerLeft += 1;
        }

        return retBool;
    }
}