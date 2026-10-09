class Lasagna
{
    
    public int ExpectedMinutesInOven()
    {
        const int WAITING_TIME_MIN = 40;
        return WAITING_TIME_MIN;
    }

    public int RemainingMinutesInOven(int currentTime)
    {
        return ExpectedMinutesInOven() - currentTime;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return 2*layers;
    }

    public int ElapsedTimeInMinutes(int layers, int currentTime)
    {
        return PreparationTimeInMinutes(layers) + currentTime;
    }
}
