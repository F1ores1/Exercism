public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return input.Where(Char.IsLetter).Select(x => char.ToLower(x)).Distinct().Count() > 25;
    }
}
