public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int i = 0;
        int sum = 0;
        while(i <= max)
        {
            sum = sum + i;
            i++;
        }
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int i = 0;
        int square = 0;
        while(i <= max)
        {
            square = square + (i * i);
            i++;
        }
        return square;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}