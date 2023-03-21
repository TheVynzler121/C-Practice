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
            if(character == prevChar){
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
    // just use "for loops" when doing leetcode
    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget)
    {
        var indexList = new List<int>();
        var loopCount = inputList.Count;
        for (int i = 0; i < loopCount; i++)
        {
            for (int j = i + 1; j < loopCount; j++)
            {
                if(inputList[i] + inputList[j] == inputTarget){
                    indexList.Add(i);
                    indexList.Add(j);
                }
            }
        }
        return indexList;
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
    public static int FirstNonrepeatingChar(string inputString)
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
        for (int i = inputNums.Count - 1; i >= 0; i--)
        {
            if(inputNums[i] == 9){
                inputNums[i] = 0;
            } else {
                inputNums[i]++;
                return inputNums;
            }
        }
        var oneList = new List<int>(){1};
        return oneList.Concat(inputNums);
    }

    public static int SingleNumber(List<int> input)
    {
        var intCount = new Dictionary<int, int>();
        var loopLength = input.Count - 1;
        foreach(var num in input)
        {
            if(intCount.ContainsKey(num)){
                intCount[num]++;
            }else{
                intCount[num] = 1;
            }
        }
        var returnInt = 0;
        foreach (var key in intCount)
        {
            if(key.Value == 1){
                returnInt = key.Key;
                return returnInt;
            }
        }
        return 0;
    }

    public static bool ContainsDuplicates(List<int> nums)
    {
       var intCount = new Dictionary<int, int>();
       foreach (var num in nums)
       {
            if(intCount.ContainsKey(num)){
                intCount[num]++;
            }else{
                intCount[num] = 1;
            }
       }
       var returnBool = false;
       foreach (var Key in intCount)
       {
            if(Key.Value >= 2){
                returnBool = true;
                return returnBool;
            }
       }
       return returnBool;
    }

    public static string LongestCommonPrefix(List<string> strs){ // why is this O(n)? because it loops through the input only once. it checks each word based off the first word.
        
        if(strs.Count == 1){ // edge case of input being 1 index, return the index.
            return strs[0];
        }

        var prefixString= "";
        
        if(strs == null || strs.Count == 0){ // another edge case for if the input is empty, return an empty string.
            return prefixString;
        }

        for (int i = 0; i < strs[0].Length; i++) // loop for the length of the first word
        {
            foreach (var str in strs) // for each word in the input
            {
                if(i > str.Length){ // if the index is greater than the length of the current word
                    return prefixString; // return the prefixString
                } else if(strs[0][i] != str[i]){ // else if the char index of the first word is not equal to the current words char index
                    return prefixString; //return the prefixString
                }
            }
            prefixString += strs[0][i]; // add the first words char index to the prefixstring
        }
        return prefixString;
    }

    public static bool ValidPalindrome(string input){
        
        if(input.Length == 1 && char.IsLetterOrDigit(input[0])){
            return true;
        }

        var lowerCaseChars = input.ToLower().ToList();
        StringBuilder palinString = new StringBuilder();
        var loopLength = palinString.Length - 1;

        foreach (var letter in lowerCaseChars)
        {
            if(char.IsLetterOrDigit(letter)){
                palinString.Append(letter);
            }
        }

        var rightPointer = palinString.Length - 1;
        var leftPointer = 0;

        while(rightPointer - leftPointer > 0){
            if(palinString[rightPointer] != palinString[leftPointer]){
                return false;
            }
            rightPointer -= 1;
            leftPointer += 1;
        }
        return true;
    }
}