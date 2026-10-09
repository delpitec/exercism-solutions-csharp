static class LogLine
{
    public static string Message(string logLine)
    {
        int initialIdx = logLine.IndexOf(":") + 1;
        return logLine.Substring(initialIdx).Trim();
    }
    public static string LogLevel(string logLine)
    {
        int initialIdx = logLine.IndexOf("[") + 1;
        int finalIdx   = logLine.IndexOf("]");
        return logLine.Substring(initialIdx, finalIdx - initialIdx).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
