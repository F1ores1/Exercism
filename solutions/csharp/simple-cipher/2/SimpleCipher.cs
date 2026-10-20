using System.Net.Http.Headers;

public class SimpleCipher
{
    public SimpleCipher()
    {
        var rnd = new Random();

        Key = string.Concat(Enumerable.Range(0, 100)
            .Select(i => (char)rnd.Next('a', 'z' + 1)));
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }
    
    public string Key { get; }

    public string Encode(string plaintext)
        => CipherOperation(plaintext, EncodeChar);

    public string Decode(string ciphertext)
        => CipherOperation(ciphertext, DecodeChar);

    private char EncodeChar(char c, char shiftKey) 
        => (char)((c - 'a' + shiftKey - 'a') % 26 + 'a');

    private char DecodeChar(char c, char shiftKey)
        => (char)((c - shiftKey + 26) % 26 + 'a');

    private string CipherOperation(string text, Func<char, char, char> cipherFunc)
        => string.Concat(text.Select((c, i) => cipherFunc(c, Key[i % Key.Length])));

}