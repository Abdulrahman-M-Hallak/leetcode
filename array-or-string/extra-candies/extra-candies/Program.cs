namespace extra_candies;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static List<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatest = candies.Max();
        var result = new List<bool>();
        foreach (int candy in candies)
        {
            if(candy + extraCandies >= greatest)
            result.Add(true);
            
            else result.Add(false);
        }
        return result;
    }
}
