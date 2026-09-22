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

        // var cleanUp = phrase.Split(["-", " "], StringSplitOptions.RemoveEmptyEntries);

        // var abv = cleanUp.Select(word 
        //     => word.FirstOrDefault(c => char.IsLetter(c)));

        // var upper = abv.Select(char.ToUpper);

        // return string.Join("", upper);

    }
}