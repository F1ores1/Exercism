using System.Net.Http.Headers;

public class SimpleCipher
{
    public SimpleCipher()
    {
        var rnd = new Random();

        Key = new string(Enumerable.Range(0,100)
            .Select(i => (char)(rnd.Next(0, 26) + 'a'))
            .ToArray());
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }
    
    public string Key 
    {
        get;
    }

    public string Encode(string plaintext)
    {
        char cipherChar(char c, char shiftKey)
        {
            
            if (!char.IsLetter(c))
                return c;

            shiftKey -= 'a';

            int lowerLimit = char.IsLower(c) ? 'a' : 'A';
            return (char)(lowerLimit + ((c - lowerLimit + shiftKey) % 26));
        }
        return new string(Enumerable.Range(0, plaintext.Length).Select(i => cipherChar(plaintext[i], Key[i % Key.Length])).ToArray());

        
    }

    public string Decode(string ciphertext)
    {
        char cipherChar(char c, char shiftKey)
        {
            if (!char.IsLetter(c))
                return c;

            shiftKey -= 'a';

            int lowerLimit = char.IsLower(c) ? 'a' : 'A';
            int delta = c - lowerLimit - shiftKey;
            delta = delta >= 0 
                ? 'a' + delta
                : 'a' + delta + 26;
            return (char)delta;
        }
        return new string(Enumerable.Range(0, ciphertext.Length).Select(i => cipherChar(ciphertext[i], Key[i % Key.Length])).ToArray());
    }
}