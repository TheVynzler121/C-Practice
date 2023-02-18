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
        // var listSeed = new List<string>();

        // foreach (var letter in inputList)
        // {
        //     listSeed.Insert(0, letter);
        // }

        // return listSeed;

        return inputList.Aggregate(new List<string>(), (listSeed, letter) => {listSeed.Insert(0, letter); return listSeed;});
    }
}