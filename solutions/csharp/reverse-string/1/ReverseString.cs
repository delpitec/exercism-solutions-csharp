public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] output = new char[input.Length];
        for(int i = 0; i < input.Length; i++)
        {
            output[input.Length - 1 - i] = input[i];
        }
        return new string(output);
    }
}