public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string sender, string delimiter)
    {
        var splitstrings = sender.Split(delimiter);
        return splitstrings[1];       
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string sender, string delimiter1, string delimiter2)
    {
        
        var splitstrings = sender.Split(new string[] { delimiter1, delimiter2 }, StringSplitOptions.None);
        return splitstrings[1];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        var splitstrings = log.Split(':' , '\\');
        return splitstrings[1].Trim();        
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logLine)
    {
        var splitstrings = logLine.Split('[', ']');
        return splitstrings[1];
    }
}