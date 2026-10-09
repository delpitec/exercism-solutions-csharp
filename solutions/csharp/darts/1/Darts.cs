public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        if(distance <= 1.0d)
        {
            return 10;
        }
        else if(distance <= 5.0d)
        {
            return 5;
        }
        else if(distance <= 10.0d)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
