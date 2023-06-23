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
        var reversedWords = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

        var builder = new StringBuilder();
        foreach (var word in reversedWords)
        {
            builder.Append(word + " ");
        }
        return builder.ToString().Trim();
    }
}
