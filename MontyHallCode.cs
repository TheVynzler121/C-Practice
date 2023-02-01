namespace C__Practice;

public class MontyHallCode {
    public static Random dice = new();

    public static int PickDoor() {
        return dice.Next(0, 3);
    }

    public static List<bool> StartGame() {
        var doors = new List<bool> { false, false, false };
        doors[PickDoor()] = true;
        return doors;
    }
}