namespace reverse_words;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var s = ReverseWords("a good   example");
        System.Console.WriteLine(s);
    }
    public static string ReverseWords(string s) => string.Join(' ', s.Split(' ' , StringSplitOptions.RemoveEmptyEntries).Reverse());
}
