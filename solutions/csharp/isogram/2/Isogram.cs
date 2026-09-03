public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word.ToLower().Where(char.IsLetter).Distinct().Count() 
            == word.Where(char.IsLetter).Count();
    }
}
