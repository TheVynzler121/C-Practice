namespace C__Practice;

public enum NumbersList {
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4
}

public enum NumbersListTwo {
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9
}

public class Arith {
    public static int add(int x, int y) {
        return x + y;
    }

    public static int subtract(int x, int y) {
        return x - y;
    }

    public static int addEnum() {
        var enumOne = (int)NumbersList.Two; //cast the enum into an int
        var enumTwo = (int)NumbersListTwo.Eight;

        return enumOne + enumTwo;
    }

    public static Dictionary<string, int> countNumbers(string[] numbersToCount) {
        var counts = new Dictionary<string, int> {
            { "1", 0 },
            { "2", 0 },
            { "3", 0 }
        };

        foreach (var number in numbersToCount) {
            counts[number]++;
        }

        return counts;
    }


    public static NumbersList extractNumber(string numberString) {
        var charToNumber = new Dictionary<char, NumbersList> {
            { '1', NumbersList.One },
            { '2', NumbersList.Two },
            { '3', NumbersList.Three },
            { '4', NumbersList.Four }
        };
        return charToNumber[numberString[0]];
    }

    public static NumbersListTwo extractNumber2(string anotherNumberString) {
        var charToNumberAgain = new Dictionary<char, NumbersListTwo> {
            { '5', NumbersListTwo.Five },
            { '6', NumbersListTwo.Six },
            { '7', NumbersListTwo.Seven },
            { '8', NumbersListTwo.Eight },
            { '9', NumbersListTwo.Nine }
        };
        return charToNumberAgain[anotherNumberString[0]];
    }
}