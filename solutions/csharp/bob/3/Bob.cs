using System.Formats.Asn1;

public static class Bob
{
    public static string Response(string statement)
    {
    
        bool IsUpper = 
            statement.Any(char.IsLetter) &&
            statement.ToUpperInvariant() == statement;
  
        
        bool IsQuestion = statement.TrimEnd().EndsWith("?");
            
        if (statement.IsWhiteSpace())
        {
            return "Fine. Be that way!";
        }
        else if (IsUpper && IsQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (IsUpper)
        {
            return "Whoa, chill out!";
        }
        else if (IsQuestion)
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
        
    }
}