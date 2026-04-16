// TODO: define the 'LogLevel' enum
enum  LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Unknown
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string log = logLine.Substring(1, 3);
        return log switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };
        throw new NotImplementedException("Please implement the (static) LogLine.ParseLogLevel() method");
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {

        return logLevel switch
        {
            LogLevel.Unknown => "0:"+message,
            LogLevel.Trace => "1:"+message,
            LogLevel.Debug => "2:"+message,
            LogLevel.Info => "4:"+message,
            LogLevel.Warning => "5:"+message,
            LogLevel.Error => "6:"+message,
            LogLevel.Fatal => "42:"+message

        };
        throw new NotImplementedException("Please implement the (static) LogLine.OutputForShortLog() method");
    }
}
