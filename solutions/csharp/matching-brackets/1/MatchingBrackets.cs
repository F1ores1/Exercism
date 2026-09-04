using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public static class MatchingBrackets
{
    public static Dictionary<char, char> Match = new Dictionary<char, char>
    {
        ['{'] = '}',
        ['('] = ')',
        ['['] = ']'

    };

    public static bool IsPaired(string input)
    {
        var MatchList = input.Where(x => Match.ContainsKey(x) || Match.ContainsValue(x)).ToList();

        var index = 0;

        char key = char.MinValue;

        while (MatchList.Count() > 0)
        {
            var nextIndex = index + 1;

            if (nextIndex >= MatchList.Count())
                return false;

            if (index == 0)
                key = MatchList[0];

            if (Match.ContainsValue(key))
                return false;

            var nextLetter = MatchList[nextIndex];

            if (nextLetter == Match[key])
            {
                MatchList.RemoveRange(index, 2);
                index = 0;
            }
            else if (Match.ContainsKey(nextLetter))
            {
                key = nextLetter;
                index ++;
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;

    }
}
