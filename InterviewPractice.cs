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

    public static IEnumerable<int> PlusOne(List<int> nums)
    {
        var loopCount = nums.Count - 1;
        for (int i = loopCount; i >= 0; i--)
        {
            if(nums[i] == 9){
                nums[i] = 0;
            } else {
                nums[i]++;
                return nums;
            }
        }
        var carriedOne = new List<int>(){1};
        return carriedOne.Concat(nums);
    }

    public static int SingleNumber(List<int> input)
    {
        var inputTally = new Dictionary<int, int>();
        foreach (var number in input)
        {
            if(inputTally.ContainsKey(number)){
                inputTally[number]++;
            } else{ 
                inputTally[number] = 1;
            }
        }

        var returnNumber = 0;
        foreach (var keyAndValue in inputTally)
        {
            if(keyAndValue.Value == 1){
                returnNumber = keyAndValue.Key;
                return returnNumber;
            }
        }
        return 0;
    }

    public static bool ContainsDuplicates(List<int> nums)
    {
        var numsCount = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if(!numsCount.ContainsKey(num)){
                numsCount[num] = 1;
            } else{
                numsCount[num]++;
            }
        }
        var boolToReturn = false;
        foreach (var key in numsCount)
        {
            if(key.Value >= 2){
                boolToReturn = true;
                return boolToReturn;
            }
        }
        return boolToReturn;
    }

    public static string LongestCommonPrefix(List<string> strs){
        
        if(strs.Count == 1){
            return strs[0];
        }

        var prefixString= "";
        
        if(strs == null || strs.Count == 0){
            return prefixString;
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (var str in strs)
            {
                if(i > str.Length){
                    return prefixString;
                } else if(strs[0][i] != str[i]){
                    return prefixString;
                }
            }
            prefixString += strs[0][i];
        }
        return prefixString;
    }


}