static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double rate = 0.0;
        if(speed == 0)
            rate = 0.0;
        else if(speed >= 1 && speed <= 4)
            rate = 1.0;
        else if(speed >= 5 && speed <= 8)
            rate = 0.90;
        else if(speed == 9)
            rate = 0.80;
        else
            rate = 0.77;

        return rate;
    }
    
    public static double ProductionRatePerHour(int speed) => 
        (speed * 221) * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => 
        (int)ProductionRatePerHour(speed) / 60;
}
