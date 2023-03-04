namespace C__Practice;

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input)
    {
        var prevCharacter = ' ';
        var outputBool = false;
        foreach (var letter in input)
        {
            if(letter == prevCharacter){
                outputBool = true;
                return outputBool;
            }
            prevCharacter = letter;
        }
        return outputBool;
    }

    public static IEnumerable<string> ReverseString(List<string> inputList)
    {
       var listOfReversedLetters = new List<string>();
       foreach (var letter in inputList)
       {
            listOfReversedLetters.Insert(0, letter);
       }
       return listOfReversedLetters;
    }
    // just use "for loops" when doing leetcode
    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget)
    {
        var listSeed = new List<int>();
        for (int currentIndex = 0; currentIndex < inputList.Count; currentIndex++)
        {
            for (int nextIndex = currentIndex + 1; nextIndex < inputList.Count; nextIndex++)
            {
                if(inputList[currentIndex] + inputList[nextIndex] == inputTarget){
                    listSeed.Add(currentIndex);
                    listSeed.Add(nextIndex);
                }
            }
        }
        return listSeed;
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

    public static IEnumerable<int> PlusOne(List<int> digits){
        for (int i = digits.Count - 1; i >= 0; i--)
        {
            if(digits[i] == 9){
                digits[i] = 0;
            } else {
                digits[i]++;
                return digits;
            }
        }
        var firstOne = new List<int>() {1};
        return firstOne.Concat(digits);
    }
}