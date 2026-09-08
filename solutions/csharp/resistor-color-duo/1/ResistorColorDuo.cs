using System.Drawing;

public static class ResistorColorDuo
{
    public static Dictionary<string, int> BandValue => new Dictionary<string, int>()
    {
        ["black"] = 0,
        ["brown"] = 1,
        ["red"] = 2,
        ["orange"] = 3,
        ["yellow"] = 4,
        ["green"] = 5,
        ["blue"] = 6,
        ["violet"] = 7,
        ["grey"] = 8,
        ["white"] = 9,
    };
    
    public static int Value(string[] colors)
    {
        if (colors.Count() > 1)
        {
            return BandValue[colors[0]] * 10 + BandValue[colors[1]];
        }
        throw new NotImplementedException("You need to implement this method.");
    }
}
