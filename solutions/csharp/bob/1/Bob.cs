using System.Formats.Asn1;

public static class Bob
{
    public static string Response(string statement)
    {
    
        bool IsUpper = 
            statement.Any(char.IsLetter) &&
            statement.Where(char.IsLetter).All(char.IsUpper);
  
        
        bool IsQuestion = false;
        if (!statement.IsWhiteSpace())
            IsQuestion = statement.Where(c => !char.IsWhiteSpace(c)).Last() == '?';
        //Console.WriteLine($"AllIsUpper {statement.All(char.IsUpper)} AllLetterUpper {statement.Where(char.IsLetter).All(char.IsUpper)}");
        Console.WriteLine($"IsUpper {IsUpper} IsQuestion {IsQuestion}");
        Console.WriteLine($"IsUpperPrint {new string(statement.Where(char.IsLetter).ToArray())}");


        if (statement.All(char.IsWhiteSpace))
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