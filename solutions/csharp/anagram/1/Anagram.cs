public class Anagram
{
    private string _baseWord;
    public Anagram(string baseWord)
        => _baseWord = baseWord.ToLower();

    public IEnumerable<string> FindAnagrams(string[] potentialMatches)
    {

        var baseGroup = _baseWord.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        foreach (var word in potentialMatches)
        {
            var lowerWord = word.ToLower();

            var wordGroup = lowerWord
                .GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            var compareCount = baseGroup.All(g =>
            {
                try { return g.Value == wordGroup[g.Key]; }
                catch {return false; }
            });

            var compareChar = Enumerable.Range(0, _baseWord.Length).All(i => _baseWord[i] == lowerWord[i]);

            if (compareCount && !compareChar)
                yield return word;
            
        }
        
    }

}