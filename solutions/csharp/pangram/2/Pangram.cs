public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool ret = false;
        string all = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < input.Length; i++)
        {
            for(int j = 0; j < all.Length; j++)
            {
                if(Char.ToLower(input[i]) == all[j])
                {
                    all = all.Remove(j, 1);
                    break;
                }
            }
             
        }
        return all.Length == 0;
    }
}

