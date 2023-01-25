namespace C__Practice;

public class RomanNumeralConverter
{
    public static string NumberToNumeral(int inputInt)
    {
        var numerals = new Dictionary<int, char>()
        {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
        };
        var returnString = "";
        if(inputInt <= 4)
        {
            for(var x = 0; x < inputInt; x++)
            {              
                returnString += numerals[1].ToString();
            }
            return returnString;
        }

        if(inputInt == 5)
        {
            returnString += numerals[5].ToString();
            return returnString;
        }

        if(inputInt <= 9)
        {
            returnString += numerals[5].ToString();
            var loopCount = inputInt - 5;
            for(var x = 0; x < loopCount; x++)
            {
                returnString += numerals[1].ToString();
            }
            return returnString;
        }

        if (inputInt == 10)
        {
            returnString += numerals[10].ToString();
            return returnString;
        }

        return returnString;
    }
}