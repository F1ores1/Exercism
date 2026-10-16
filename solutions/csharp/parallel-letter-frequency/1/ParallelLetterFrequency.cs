
using System.Threading.Tasks;
public static class ParallelLetterFrequency
{
    private static Dictionary<char, int> LetterDictionary = new();
    public static async Task<Dictionary<char, int>> Calculate(IEnumerable<string> texts)
    {
        LetterDictionary = new();
        var letterTasks = new List<Task>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            letterTasks.Add(LetterCount(c, texts));
        }

        await Task.WhenAll(letterTasks);
        return LetterDictionary;
    }

    static async Task LetterCount(char letter, IEnumerable<string> texts)
    {
        var count = texts
            .Sum(word => word
            .Select(char.ToLower)
            .Count(c => c == letter));
        if (count > 0)
            LetterDictionary.Add(letter, count);
        
        
    }
}