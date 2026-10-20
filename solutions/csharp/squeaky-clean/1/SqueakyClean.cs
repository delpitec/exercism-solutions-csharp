using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder text = new StringBuilder(identifier);
   
        for (int i = 0; i < text.Length; i++)
        {
            if((text[i] == '-') && (i + 1 < text.Length))
                text[i+1] = char.ToUpper(text[i+1]);
            else if(text[i] >= 'α' && text[i] <= 'ω')
                text[i] = '-';
            else if(text[i] >= '0' && text[i] <= '9')
                text[i] = '-';
            else if(!char.IsLetterOrDigit(text[i]) && text[i] != ' ' && text[i] != '\0')
                text[i] = '-';
        }
        text.Replace(" ", "_");
        text.Replace("\0", "CTRL");
        text.Replace("-", "");

        return text.ToString();
    }
}
