namespace C__Practice;

public class RomanNumeralConverter
{

    // right now the whole function goes small -> large
    // but each new digit goes large -> small
    // perhaps the whole function could just go large -> small?
    // notice how the roman numerals are always large -> small
    // without functions, you have all the statements needed 
    // to reduce it by 50% at least
    // reduce without making any functions
    // subtraction is the trick
    public static string NumberToNumeral(int inputInt)
    {
        var numerals = new Dictionary<int, char>()
        {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
        };
        var returnString = "";
        if (inputInt <= 4)
        {
            for (var x = 0; x < inputInt; x++)
            {
                returnString += numerals[1].ToString();
            }
            return returnString;
        }

        if (inputInt == 5)
        {
            returnString += numerals[5].ToString();
            return returnString;
        }

        if (inputInt <= 9)
        {
            returnString += numerals[5].ToString();
            var loopCount = inputInt - 5;
            for (var x = 0; x < loopCount; x++)
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

        if (inputInt <= 14)
        {
            returnString += numerals[10].ToString();
            var loopCount = inputInt - 10;
            for (int x = 0; x < loopCount; x++)
            {
                returnString += numerals[1].ToString();
            }
            return returnString;
        }
        return returnString;
    }


    public static int RomanToArabic(string inputString)
    {
        var charCount = 0;
        
        var loopCount = inputString.Length;
        for (int x = 0; x < loopCount; x++)
        {
            var character = inputString[x];
            var nextCharacter = ' ';
            var nextIndex = x+1;
            var canLookAhead = x < loopCount - 1;
            if(canLookAhead ) {
                nextCharacter = inputString[nextIndex];
            } 
            
            if (character == 'X')
            {
                charCount += 10;
            }

            if (character == 'V')
            {
                charCount += 5;
            }

            if(character == 'I' && nextCharacter == 'X')
            {
                charCount += 9;
                x++;
            }
            else if (character == 'I' && nextCharacter == 'V')
            {
                charCount += 4;
                x++;
            }
            else if (character == 'I')
            {
                charCount++;
            }
            
        }
        return charCount;
    }
}