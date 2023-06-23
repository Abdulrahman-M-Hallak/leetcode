using System.Text;

namespace reverse_words;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var s = ReverseWords("a good   example");
        System.Console.WriteLine("Hellower");
    }
    public static string ReverseWords(string s)
    {
        return string.Join(' ', s.Split(' ' , StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}
