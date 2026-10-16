
using System.Threading.Tasks;
public static class ParallelLetterFrequency
{
    private static Dictionary<char, int> LetterDictionary = new();
    public static async Task<Dictionary<char, int>> Calculate(IEnumerable<string> texts)
    {
        return texts
            .AsParallel()
            .SelectMany(w => w.ToLower())
            .Where(char.IsLetter)
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

    }


}