public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastTwo = number % 100;
        string ordinal = "";

        if (lastTwo >= 11 && lastTwo <= 13)
        {
            ordinal = "th";
        }
        else
        {
            if(lastTwo % 10 == 1)
                ordinal = "st";
            else if(lastTwo % 10 == 2)
                ordinal = "nd";
            else if (lastTwo % 10 == 3)
                ordinal = "rd";
            else 
                ordinal = "th";
        }
        
        string retMsg = $"{name}, you are the {number.ToString()}{ordinal} customer we serve today. Thank you!";
        
        return retMsg;
    }
}
