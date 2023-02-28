namespace C__Practice;

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input)
    {
        var previousLetter = ' ';
        foreach (var letter in input)
        {
            if (previousLetter == letter)
            {
                return true;
            }
            previousLetter = letter;
        }
        return false;
    }

    public static IEnumerable<string> ReverseString(List<string> inputList)
    {
       var seedlist = new List<string>();
       foreach (var letter in inputList)
       {
            seedlist.Insert(0, letter);
       }
       return seedlist;
    }
    // just use for loops when doing leetcode
    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget)
    {
        var seedList = new List<int>();
        var listLength = inputList.Count;

        for (int i = 0; i < listLength; i++)
        {
            for (int j = i + 1; j < listLength; j++)
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

    public static int FirstNonrepeatingChar(string inputString)
    {
        var stringDictionary = new Dictionary<char, List<int>>();
        for (int i = 0; i < inputString.Length; i++)
        {
            var character = inputString[i];
            if(!stringDictionary.ContainsKey(character)){
                stringDictionary.Add(character, new List<int>(new int[]{i}));
            }else{
                stringDictionary[character].Add(i);
            }
        }

        for (int i = 0; i < inputString.Length; i++)
        {
            var character = inputString[i];
            if(stringDictionary[character].Count == 1){
                return stringDictionary[character][0];
            }
        }
        return -1;
    }
}