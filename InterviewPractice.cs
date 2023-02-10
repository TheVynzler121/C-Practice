namespace C__Practice;

public class InterviewPractice
{
    public static bool ConsecutiveDuplicates(string input){
        // var previousChar = ' ';

        // foreach (var letter in input)
        // {
        //     if(previousChar == letter){ 
        //         return true;
        //     }
        //     previousChar = letter;  

        // }       
        // return false;


        // we don't need to check the last character
        var lastIndex = input.Length - 1;
        for (int index = 0; index < lastIndex; index++)
        {
            var nextIndex = index + 1;
            var currentCharacter = input[index];
            var nextCharacter = input[nextIndex];
            if (currentCharacter == nextCharacter)
            {
                return true;
            }
        }

        return false;
    }

    public static List<string> ReverseString(List<string> input){
        var stringListSeed = new List<string>();
        foreach (var letter in input)
        {
            stringListSeed.Insert(0, letter);
        }
        return stringListSeed;
    }
}