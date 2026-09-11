using System.Security.Cryptography.X509Certificates;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        return input.Sum(letterVal);

        int letterVal(char letter)
        {
            string one = "A, E, I, O, U, L, N, R, S, T";
            string two = "D, G";
            string three = "B, C, M, P";
            string four = "F, H, V, W, Y";
            string five = "K";
            string eight = "J, X";
            string ten = "Q, Z";

            letter = char.ToUpper(letter);
            return letter switch
            {
                _ when one.Contains(letter) => 1,
                _ when two.Contains(letter) => 2,
                _ when three.Contains(letter) => 3,
                _ when four.Contains(letter) => 4,
                _ when five.Contains(letter) => 5,
                _ when eight.Contains(letter) => 8,
                _ when ten.Contains(letter) => 10,
                _ => 0
            };
            
        }
    }
}