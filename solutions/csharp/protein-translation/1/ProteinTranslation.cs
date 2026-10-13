using Xunit.Sdk;

public static class ProteinTranslation
{
    public static IEnumerable<string> Proteins(string strand)
    {
        if (strand.Length < 1)
            yield break;
        
        for (int i = 0; i < strand.Length; i += 3)
        {
            var protein = strand.Substring(i, 3);

            string map(string protein) => protein switch
            {
                "AUG" => "Methionine",
                "UUU" or "UUC" => "Phenylalanine",
                "UUA" or "UUG" => "Leucine",
                "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
                "UAU" or "UAC" => "Tyrosine",
                "UGU" or "UGC" => "Cysteine",
                "UGG" => "Tryptophan",
                "UAA" or "UAG" or "UGA" => "STOP",
                _ => throw new ArgumentException()
            };

            if (map(protein) == "STOP")
                yield break;

            yield return map(protein);





        }

        
    }
}