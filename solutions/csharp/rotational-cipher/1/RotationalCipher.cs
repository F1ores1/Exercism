public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        // foreach (char letter in text)
        // {
        //     if (char.IsUpper(letter) || char.IsLower(letter))
        //     {
        //         letter = letter + shiftKey;
        //     }

            
        // }
        string cipherString ="";
        for (int i = 0; i < text.Length; i++)
        {

            int shift = 0;
            if (char.IsLower(text[i]))
            {
                shift = text[i] + shiftKey;
                if (shift > 122)
                {
                    shift = shift - 26;
                }
                cipherString += (char)shift;
            }
            else if (char.IsUpper(text[i]))
            {
                shift = text[i] + shiftKey;
                if (shift > 90)
                {
                    shift = shift - 26;
                }
                cipherString += (char)shift;
            }
            else
            {
                cipherString += text[i];
            }
        }

        return cipherString;

    }
}