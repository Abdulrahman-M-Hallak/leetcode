namespace is_subsequence;

internal class Program
{
    static void Main(string[] args)
    {
        IsSubsequence("abc", "b");
        Console.WriteLine("Helloworld");
    }
    public static bool IsSubsequence(string text , string subText)
    {
        int i =0 , j =0 ;
        while(i < text.Length && j < subText.Length)
        {
            if (text[i] == subText[j])
                j++;
            i++;
        }
        return j == subText.Length;
    }
}
