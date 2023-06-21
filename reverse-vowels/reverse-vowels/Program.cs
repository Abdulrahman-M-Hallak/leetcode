namespace reverse_vowels;
class Program
{
    private static readonly HashSet<char> s_vowels = new()
    {
        'a' , 'e' , 'u' , 'i' , 'o', 'A', 'E' , 'U' , 'I' , 'O'
    };
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string s = "Hello";
        var f = ReverseVowels(s);
        System.Console.WriteLine(f);
    }

    public static string ReverseVowels(string s)
    {
        // A temporary array so that i can reassign the values of the letters.
        var f = s.ToCharArray();

        var vowelsInString = new List<char>
        (
            s.Where(x => s_vowels.TryGetValue(x, out var vowels))
        );
        vowelsInString.Reverse();
        
        for (int i = 0; vowelsInString.Any(); i++)
        {
            if (s_vowels.TryGetValue(f[i], out var vowels))
            {
                f[i] = vowelsInString.First();
                vowelsInString.RemoveAt(0);
            }

        }
        return new string(f);
    }
}
