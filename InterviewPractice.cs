namespace C__Practice;

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input){
        var previousLetter = ' ';
        foreach (var letter in input)
        {
            if(previousLetter == letter){
                return true;
            }
            previousLetter = letter;
        }
        return false;


        // we don't need to check the last character
        // var lastIndex = input.Length - 1;
        // for (int index = 0; index < lastIndex; index++)
        // {
        //     var nextIndex = index + 1;
        //     var currentCharacter = input[index];
        //     var nextCharacter = input[nextIndex];
        //     if (currentCharacter == nextCharacter)
        //     {
        //         return true;
        //     }
        // }

        // return false;
    }

    public static IEnumerable<string> ReverseString(List<string> inputList){
        var listSeed = new List<string>();
        foreach (var letter in inputList)
        {
            listSeed.Insert(0, letter.ToString());
        }
        return listSeed;
    }
// just use for loops when doing leetcode
    public static IEnumerable<int> TwoSum(List<int> inputList, int inputTarget){
        var seedList = new List<int>();
        var listLength = inputList.Count;

        for (int i = 0; i < listLength; i++)
        {
            for (int j = i + 1; j < listLength; j++)
            {
                if(inputList[i] + inputList[j] == inputTarget){
                    seedList.Add(i);
                    seedList.Add(j);
                }
            }
        }

        return seedList;
    }
}