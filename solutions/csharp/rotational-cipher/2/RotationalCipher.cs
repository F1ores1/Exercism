using System.Security.Cryptography.X509Certificates;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char cipherChar(char c)
        {
            if (!char.IsLetter(c))
                return c;
            
            int lowerLimit = char.IsLower(c) ? 'a' : 'A';
            return (char)(lowerLimit + ((c - lowerLimit + shiftKey) % 26));
        }



        return new string(text.Select(cipherChar).ToArray());

    }
}