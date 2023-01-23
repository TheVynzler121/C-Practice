namespace C__Practice;

public class MontyHalltest
{
    [Test]
    public void Test_MontyHall_StickWithSameDoor()
    {
        var actualWinCount = 0;

        var timesPlaying = 10000;

        for (var x = 0; x < timesPlaying; x++)
        {
            var doors = MontyHallCode.StartGame();
            var choosenDoor = MontyHallCode.PickDoor();
            // announcer opens a false door ...

            if (doors[choosenDoor])
            {
                actualWinCount++;
            }
        }

        AssertApproximateWinPercentage(actualWinCount, timesPlaying, 0.33);
    }

    [Test]
    public void Test_MontyHall_SwitchDoor()
    {
        var actualWinCount = 0;

        var timesPlaying = 10000;

        for (var x = 0; x < timesPlaying; x++)
        {
            // {false, false, true}
            var doors = MontyHallCode.StartGame();
            // 1
            var chosenDoor = MontyHallCode.PickDoor();
            // {true, [false], false}

            // announcer opens a false door ...
            var badDoor = 0;
            for (var door = 0; door < 3; door++)
            {
                if (door != chosenDoor && doors[door] != true)
                {
                    badDoor = door;
                }
            }
	    // union / difference
	    // union ([1,2,3], [4,5]) => [1,2,3,4,5]
	    // union ([1,2,3], [3,5]) => [1,2,3,5]

	    // difference ([1,2,3], [4,5]) => [1,2,3]
	    // difference ([0,1,2], [0,2]) => [1]
	    // difference ([0,1,2], [1,2]) => [0]
	    var allDoors = new HashSet<int>() {0,1,2};
	    allDoors.ExceptWith(new HashSet<int>() {chosenDoor, badDoor});
	    chosenDoor = allDoors.First();

            if (doors[chosenDoor])
            {
                actualWinCount++;
            }
        }
        Console.WriteLine(actualWinCount);
        AssertApproximateWinPercentage(actualWinCount, timesPlaying, 0.66);
    }

    private static void AssertApproximateWinPercentage(int actualWinCount, int timesPlaying, double percent)
    {
        var expectedWinCount = timesPlaying * percent;
        var graceZone = expectedWinCount * 0.1;
        var differencBetweenExepectedAndActual = Math.Abs(expectedWinCount - actualWinCount);

        Assert.True(differencBetweenExepectedAndActual < graceZone);
    }
}