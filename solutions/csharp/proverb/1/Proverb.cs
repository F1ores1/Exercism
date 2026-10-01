using System.Security.Cryptography.X509Certificates;

public static class Proverb
{
    public static IEnumerable<string> Recite(string[] subjects)
    {
        if (subjects.Length < 1)
            yield break;
        for (int i = 1; i < subjects.Length; i++)
        {
            yield return $"For want of a {subjects[i-1]} the {subjects[i]} was lost.";
        }
        yield return $"And all for the want of a {subjects[0]}.";
        
    }
}