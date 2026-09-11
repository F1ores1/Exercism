using System.Security.Cryptography.X509Certificates;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        // return input.Sum(letterVal);

        Dictionary<string, int> letterVals = new()
        {
            ["A, E, I, O, U, L, N, R, S, T"] = 1,
            ["D, G"] = 2,
            ["B, C, M, P"] = 3,
            ["F, H, V, W, Y"] = 4,
            ["K"] = 5,
            ["J, X"] = 8 ,
            ["Q, Z"] = 10
        };


        return input.Sum(letterVal);



        int letterVal(char letter)
        {
            letter = char.ToUpper(letter);

            return letterVals.FirstOrDefault(s => s.Key.Contains(letter)).Value;
            
        }
    }
}