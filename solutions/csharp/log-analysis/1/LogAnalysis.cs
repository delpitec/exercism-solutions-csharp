public static class LogAnalysis 
{
    static public string SubstringAfter(this string message, string searchStrStart)
    {
        int startIdx = message.IndexOf(searchStrStart) + searchStrStart.Length;
        return message.Substring(startIdx);
    }

    static public string SubstringBetween(this string message, string searchStrStart, string searchStrEnd)
    {
        int startIdx = message.IndexOf(searchStrStart) + searchStrStart.Length;
        int   endIdx = message.IndexOf(searchStrEnd) - startIdx;
        return message.Substring(startIdx, endIdx);
    }
    
    static public string Message(this string message)
    {
        return message.SubstringAfter("]: ");
    }

    static public string LogLevel(this string message)
    {
        return message.SubstringBetween("[", "]");
    }
}