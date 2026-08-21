using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dna = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (var letter in sequence)
        {
            if (dna.ContainsKey(letter))
            {
                dna[letter]++;
            }
            else
            {
                throw new ArgumentException($"Invalid Sequence, contains letter {letter}");
            }

            
        }
        return dna;
    }
}