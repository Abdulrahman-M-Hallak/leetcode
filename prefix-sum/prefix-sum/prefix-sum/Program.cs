namespace prefix_sum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int LargestAltitude(int[] gain)
    {
        int highest = 0, sum = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            sum += gain[i];
            highest = Math.Max(highest, sum);
        }
        return highest;
    }
}
