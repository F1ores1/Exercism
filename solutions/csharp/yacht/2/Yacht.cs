public enum YachtCategory
{
    Ones = 1,
    Twos = 2,
    Threes = 3,
    Fours = 4,
    Fives = 5,
    Sixes = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    LittleStraight = 9,
    BigStraight = 10,
    Choice = 11,
    Yacht = 12,
}

public static class YachtGame
{
    public static int Score(int[] dice, YachtCategory category)
    {
        var groups= dice
            .CountBy(x => x)
            .ToDictionary(x => x.Key, x => x.Value);

        var mainGroup = groups
            .FirstOrDefault(x => x.Value >= 3);

        var smallGroup = groups
            .FirstOrDefault(x => x.Value == 2);

        switch ((int)category)
        {
            case >= 1 and <= 6:
                return dice.Count(x => x == (int)category) * (int)category;
            case 7 when mainGroup.Value == 3 && smallGroup.Value == 2:
                return mainGroup.Key * 3 + smallGroup.Key * 2;
            case 8 when mainGroup.Value >= 4:
                return mainGroup.Key * 4;
            case 9 when dice.Sum() == 15:
                return 30;
            case 10 when dice.Sum() == 20:
                return 30;
            case 11:
                return dice.Sum();
            case 12 when mainGroup.Value == 5:
                return 50;
            default:
                return 0;
        }
    }
}

