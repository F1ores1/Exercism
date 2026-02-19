static class LogLine
{
    public static string Message(string logLine)
    {
        var splitstrings = logLine.Split(':' , '\\');
        return splitstrings[1].Trim();
        
    }

    public static string LogLevel(string logLine)
    {
        var splitstrings = logLine.Split('[', ']');
        return splitstrings[1].ToLower();
    }

    public static string Reformat(string logLine)
    {
        var message = LogLine.Message(logLine);
        var loglevel = LogLine.LogLevel(logLine);
        return message + " (" + loglevel + ")";
    }
}
