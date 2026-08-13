public static class ResistorColor
{
    public static Dictionary<string, int> colorCode 
        = new Dictionary<string, int>()
        {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9}
        };
    public static int ColorCode(string color)
    {
        return colorCode[color];
    }

    public static string[] Colors()
    {
        string[] colors = new string[10];
        foreach (var color in colorCode)
        {
            colors[color.Value] = color.Key;
        }
        return colors;
    }
}