public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool ret = false;
        if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            return true;
        }
        return ret;
    }
}