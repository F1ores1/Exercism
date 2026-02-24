using System.Text;


public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder(identifier);
        StringBuilder modify = new StringBuilder();        
        sb.Replace(" ", "_");
        sb.Replace("\0", "CTRL");
        sb.Replace("-ḃ", "Ḃ");
        sb.Replace("-a", "A");
        string sbstring = sb.ToString();
        foreach (var item in sbstring)
        {
            if (char.IsLetter(item) | item == '_')
            {
                if (item < '\u03B1' | item > '\u03C9')
                {
                    modify.Append(item);
                    
                }
                
            }

        }
       

        return modify.ToString();
    }
}
