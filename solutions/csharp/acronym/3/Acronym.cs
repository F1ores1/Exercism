using System.Xml;

using Xunit.Internal;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (phrase.Length < 1)
            throw new ArgumentException();

        var ABV = phrase
            .Split(["-", " "], StringSplitOptions.RemoveEmptyEntries)
            .Select(word=> word.FirstOrDefault(c => char.IsLetter(c)))
            .Select(char.ToUpper);

        return string.Join("", ABV);

    }
}