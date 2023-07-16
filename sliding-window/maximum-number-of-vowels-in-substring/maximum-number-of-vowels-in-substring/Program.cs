namespace maximum_number_of_vowels_in_substring;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int MaxVowels(string s, int k)
    {
        int maxVowels = 0, subVowels = 0;
        for (int i = 0; i < k; i++)
            if (IsVowel(s[i]))
                subVowels++;
        maxVowels = subVowels;

        for (int i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k]))
                subVowels--;

            if (IsVowel(s[i]))
                subVowels++;
            maxVowels = Math.Max(maxVowels, subVowels);
        }
        return maxVowels;
    }
    private static bool IsVowel(char letter) => letter switch
    {
        'a' or 'A' => true,
        'e' or 'E' => true,
        'i' or 'I' => true,
        'o' or 'O' => true,
        'u' or 'U' => true,
        _ => false
    };
}
