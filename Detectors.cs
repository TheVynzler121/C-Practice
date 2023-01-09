namespace C__Practice;

public class Detectors
{
    public static string DetectHighCard(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand);
        var highCard = hand.ToList()[0];

        foreach (var card in hand)
        {
            if (card.Face > highCard.Face)
            {
                highCard = card;
            }
        }
        return $"High card is : {Formatters.printCard(highCard)}";
    }

    public static string DectectPair(string inputHand)
    {
        var hand = Parsers.parseHand(inputHand);

        var counts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (var card in hand)
        {
            counts[card.Face]++;
        }

        return toString(counts);
    }

    public static string toString<T>(List<T> intput) {
	var s = "";
	foreach(var t in intput) {
		s += t.ToString() + ",";
	}
	return s;

    }
    // detectHand string -> string
}