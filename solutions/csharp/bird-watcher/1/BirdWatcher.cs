class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {   // => [0, 2, 5, 3, 7, 8, 4]
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] = birdsPerDay[^1] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool ret = false;
        for(int i = 0; i < birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] == 0)
                ret = true;
        }
        return ret;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counts = 0;
        for(int i = 0; i < birdsPerDay.Length && i < numberOfDays; i++)
        {
            counts = counts + birdsPerDay[i];
        }
        return counts;
    }

    public int BusyDays()
    {
        int counts = 0;
        for(int i = 0; i < birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] >= 5)
                counts++;
        }
        return counts;
    }
}
