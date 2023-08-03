namespace two_strings_are_close;
class Program
{
    static void Main(string[] args)
    {
        // CloseStrings("mkmczky", "cckcmmy");
    }
    public static bool CloseStrings(string word1, string word2)
    {
        // Check if both strings are not of the same length because you cannot add characters.
        if (word1.Length != word2.Length)
            return false;

        // Check if both strings has the same characters because you can
        // only convert one existing character to one existing character.
        for (int i = 0; i < word1.Length; i++)
            if (!word2.Contains(word1[i]))
                return false;

        // Check if the two strings have the same number of characters.
        var dic1 = new Dictionary<char, int>();
        var dic2 = new Dictionary<char, int>();
        for (int i = 0; i < word1.Length; i++)
        {
            if (!dic1.TryAdd(word1[i], 1))
                dic1[word1[i]] += 1;

            if (!dic2.TryAdd(word2[i], 1))
                dic2[word2[i]] += 1;
        }
        var list1 = dic1.Values.ToList();
        var list2 = dic2.Values.ToList();

        list1.Sort(); list2.Sort();

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
                return false;
        }
        return true;
    }
}