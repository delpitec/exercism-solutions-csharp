public static class SquareRoot
{
    public static int Root(int number)
    {
        int idx = 0;
        while(idx * idx < number)
        {
            idx++;
        }
        return idx;
    }
}
