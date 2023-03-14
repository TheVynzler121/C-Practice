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
        var revStringList = new List<string>();
        var loopCount = inputList.Count;
        for (int i = 0; i < loopCount; i++)
        {
            var currChar = inputList[i];
            revStringList.Insert(0, inputList[i]);
        }
        return revStringList;
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

    public static IEnumerable<int> PlusOne(List<int> input)
    {
        var loopCount = input.Count - 1;
        for (int i = loopCount; i >= 0; i--)
        {
            if(input[i] == 9){
                input[i] = 0;
            } else {
                input[i]++;
                return input;
            }
        }
        var carriedOne = new List<int>() {1};
        return carriedOne.Concat(input);
    }

    public static int SingleNumber(List<int> input)
    {
        var countDict = new Dictionary<int, int>();
        foreach (var number in input)
        {
            if (countDict.ContainsKey(number))
            {
                countDict[number]++;
            }
            else
            {
                countDict[number] = 1;
            }
        }

        var retNumber = 0;
        foreach (var keyValuePair in countDict)
        {
            if (keyValuePair.Value == 1)
            {
                retNumber = keyValuePair.Key;
            }
        }
        return retNumber;
    }

    public static bool ContainsDuplicates(List<int> input)
    {
        var countDict = new Dictionary<int, int>();
        foreach (var number in input)
        {
            if (countDict.ContainsKey(number))
            {
                countDict[number]++;
            }
            else
            {
                countDict[number] = 1;
            }
        }
        var retBool = false;
        foreach (var keyValuePair in countDict)
        {
            if (keyValuePair.Value >= 2)
            {
                retBool = true;
                return retBool;
            }
        }
        return retBool;
    }


}