namespace C__Practice;

// List<T> is-a IEnumerable<T>
// Dictionary<T, U> is-a IEnumerable<T>
public class CompundSequenceAbstractions {
    public static Random dice = new();

    public static IEnumerable<int> AddTenIfBigEnough(IEnumerable<int> numbList) {
        return numbList.Where(numb => numb >= 4).Select(numb => numb += 10);
    }


    public static string Capitalize(string x) {
        return x[0].ToString().ToUpper() + x.Substring(1);
    }

    public static IEnumerable<string> NamesStartingWithR(IEnumerable<string> nameList) {
        return nameList.Where(name => name[0] == 'r').Select(name => Capitalize(name));
    }

    // LINQ - helper functions for sequence abstractions
    // Select, Where, Count, Average
    public static IEnumerable<int> ReturnNumbersGreaterThanAverage(IEnumerable<int> numbList) {
        var numbAverage = numbList.Average();
        return numbList.Where(numb => numb > numbAverage);
    }

    // List<T> is-a IEnumerable<T>
    public static IEnumerable<string> ItemsICanAfford(IEnumerable<GameItem> itemList, int budget) {
        return itemList.Where(item => item.GoldCost < budget).Select(item => item.Name);
    }

    public static string GetFirstWord(string sentence) {
        return sentence.Split(' ')[0];
    }

    public static IEnumerable<string> FirstWordIfStartsWith(IEnumerable<GameItem> inputList, char firstLetter) {
        return inputList.Where(item => item.Name[0] == firstLetter).Select(item => GetFirstWord(item.Name));
    }

    public static IEnumerable<string> NumbersLargerThanFiveToString(List<int> numbList) {
       return numbList.Where(num => num > 5).Select(num => num.ToString());
    }

    public static IEnumerable<int> GoldCostIfStartsWith(List<GameItem> gameItems, char firstLetter){
        return gameItems.Where(item => item.Name[0] == firstLetter).Select(item => item.GoldCost);
    }

    public static string NumberOfWordsToString(IEnumerable<string> inputList) {
        var wordCount = 0;
        foreach (var word in inputList) {
            wordCount++;
        }

        return $"There are {wordCount} words";
    }

    public static void PrintList<T>(IEnumerable<T> input) {
        Console.WriteLine("[");
        foreach (var x in input) {
            Console.WriteLine(x);
        }

        Console.WriteLine("]");
    }

    public static void PrintDictionary<T, U>(Dictionary<T, U> input) {
        Console.WriteLine("[");
        foreach (var x in input) {
            Console.WriteLine($"{x.Key} : {x.Value}");
        }

        Console.WriteLine("]");
    }

    
    public static char HighestFrequencyCharacter(string inputString) {
        var characterCounts = new Dictionary<char, int>(); // Seed for the characters
        foreach (var character in inputString) { // character = each individual character in the string
            if (characterCounts.ContainsKey(character)) { // if the dictionary contains a key matching the current character
                characterCounts[character]++; // increase the characters value in the dictionary
            } else {
                characterCounts[character] = 1;// otherwise add the character as a key with value of 1
            }
        }

        var highestCount = 0; // seed for the character count
        var highestChar = ' '; // seed for the character we want to return
        foreach (var keyValuePair in characterCounts) { // keyValuePair = every entry in the characterCounts dictionary
            if (keyValuePair.Value > highestCount) { // if the value of the current key value pair is higher than the highestCount
                highestCount = keyValuePair.Value; // highest count is now the value of the current keyValuePair
                highestChar = keyValuePair.Key; // highestChar is now the Key of the current keyValuePair
            }
        }

        return highestChar;
    }

    public static int RollDice() {
        // var tenPercent = dice.Next(1, 10);
        // if(tenPercent == 1) {
        //     return 6;
        // }
        return dice.Next(1, 7);
    }
}