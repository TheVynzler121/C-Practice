namespace C__Practice;

public class RomanNumeralConverter {
    // right now the whole function goes small -> large
    // but each new digit goes large -> small
    // perhaps the whole function could just go large -> small?
    // notice how the roman numerals are always large -> small
    // without functions, you have all the statements needed 
    // to reduce it by 50% at least
    // reduce without making any functions
    // subtraction is the trick
    public static string NumberToNumeral(int remainingArabicNumbers) {
        var numerals = new Dictionary<int, string> {
            { 1000, "M" },
            { 900, "CM"},
            { 500, "D" },
            { 400, "CD"},
            { 100, "C" },
            { 90, "XC"},
            { 50, "L" },
            { 40, "XL"},         
            { 10, "X" },
            { 9, "IX"},
            { 5, "V" },
            { 4, "IV"},
            { 1, "I" }
        };
        var returnString = "";

        foreach (var arabicAndRoman in numerals) {
            var arabicInt = arabicAndRoman.Key;
            var romanString = arabicAndRoman.Value;

            while (remainingArabicNumbers >= arabicInt) {
                returnString += romanString;
                remainingArabicNumbers -= arabicInt;
            }
        }

        return returnString;
    }


    public static int RomanToArabic(string inputString) {
        var charCount = 0;

        var loopCount = inputString.Length;
        for (var x = 0; x < loopCount; x++) {
            var character = inputString[x];
            var nextCharacter = ' ';
            var nextIndex = x + 1;
            var canLookAhead = x < loopCount - 1;
            if (canLookAhead) {
                nextCharacter = inputString[nextIndex];
            }

            if (character == 'M') {
                charCount += 1000;
            }

            if (character == 'D') {
                charCount += 500;
            }

            if (character == 'C' && nextCharacter == 'M') {
                charCount += 900;
                x++;
            } else if (character == 'C' && nextCharacter == 'D') {
                charCount += 400;
                x++;
            } else if (character == 'C') {
                charCount += 100;
            }

            if (character == 'L') {
                charCount += 50;
            }

            if (character == 'X' && nextCharacter == 'C') {
                charCount += 90;
                x++;
            } else if (character == 'X' && nextCharacter == 'L') {
                charCount += 40;
                x++;
            } else if (character == 'X') {
                charCount += 10;
            }

            if (character == 'V') {
                charCount += 5;
            }

            if (character == 'I' && nextCharacter == 'X') {
                charCount += 9;
                x++;
            } else if (character == 'I' && nextCharacter == 'V') {
                charCount += 4;
                x++;
            } else if (character == 'I') {
                charCount++;
            }
        }

        return charCount;
    }
}