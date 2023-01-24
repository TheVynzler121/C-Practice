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
        }

        if(inputInt == 5)
        {
            returnString += numerals[5].ToString();
        }

        if (inputInt == 10)
        {
            returnString += numerals[10].ToString();
        }

        return returnString;
    }
}