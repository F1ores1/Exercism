public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newDict = new();

        foreach (var index in old)
        {
            foreach (var letter in index.Value)
            {
                newDict.Add(letter.ToLower(), index.Key);
            }
        }
        return newDict;
    }
}