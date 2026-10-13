public static class ProteinTranslation
{
    public static IEnumerable<string> Proteins(string strand)
    {
        for (int i = 0; i < strand.Length; i += 3)
        {
            var protein = Translate(strand.Substring(i, 3));

            if (protein == "STOP")
                yield break;

            yield return protein;
        }
    }

    private static string Translate(string codon) => codon switch
    {
        "AUG" => "Methionine",
        "UUU" or "UUC" => "Phenylalanine",
        "UUA" or "UUG" => "Leucine",
        "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
        "UAU" or "UAC" => "Tyrosine",
        "UGU" or "UGC" => "Cysteine",
        "UGG" => "Tryptophan",
        "UAA" or "UAG" or "UGA" => "STOP",
        _ => throw new ArgumentException($"Invalid codon: {codon}")
    };
}