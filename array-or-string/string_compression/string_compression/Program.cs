using System.Diagnostics;
using System.Text;

namespace string_compression;
class Program
{
    static void Main(string[] args)
    {
        var timer = new Stopwatch();
        timer.Start();
        CompressString(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
        CompressString(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
        timer.Stop();
        Console.WriteLine("Hello, World!");
    }
    public static int CompressString(char[] chars)
    {
        if (chars.Length < 1)
            return 1;

        var builder = new StringBuilder(chars.Length);
        builder.Append(chars[0]);

        int i = 1;
        while (i < chars.Length)
        {
            int timesRepeated = 1;

            while (i < chars.Length && (chars[i] == chars[i - 1]))
            {
                timesRepeated++;
                i++;
            }
            // Do not increment i because you already did so in the while loop.
            if (timesRepeated > 1)
                builder.Append(timesRepeated);

            // Increment it because the program did not enter the while loop.
            else
            {
                builder.Append(chars[i]);
                i++;
            }
        }
        return builder.Length;
    }
}