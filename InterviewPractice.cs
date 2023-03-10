namespace C__Practice;

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input)
    {
        var prevChar = ' ';
        foreach (var currentCharacter in input)
        {
            if(currentCharacter == prevChar){
                return true;
            }
            prevChar = currentCharacter;
        }
        return false;
    }

    public static IEnumerable<string> ReverseString(List<string> inputList)
    {
       var reversedString = new List<string>();
       foreach (var character in inputList)
       {
            reversedString.Insert(0, character);
       }
       return reversedString;
    }
    // just use "for loops" when doing leetcode
    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget)
    {
        var retList = new List<int>();
        var loopCount = inputList.Count;
        for (int i = 0; i < loopCount; i++)
        {
            for (int j = i + 1; j < loopCount; j++)
            {
                if (inputList[i] + inputList[j] == inputTarget)
                {
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

    public static IEnumerable<int> PlusOne(List<int> digits)
    {
        for (int i = digits.Count - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }
        var firstOne = new List<int>() { 1 };
        return firstOne.Concat(digits);
    }

    public static int SingleNumber(List<int> input)
    {
        var countingDictionary = new Dictionary<int, int>();

        foreach (var number in input)
        {
            if (countingDictionary.ContainsKey(number))
            {
                countingDictionary[number]++;
            }
            else
            {
                countingDictionary[number] = 1;
            }
        }
        var retInt = 0;
        foreach (var number in countingDictionary)
        {
            if (number.Value == 1)
            {
                retInt = number.Key;
            }
        }
        return retInt;
    }
}