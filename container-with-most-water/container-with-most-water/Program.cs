namespace container_with_most_water;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
    }
    public static int MaxArea(int[] height)
    {
        if (!height.Any())
            return 0;

        int i = 0, j = height.Length - 1;
        int maxArea = j * height[j];
        int tempArea = 0;
        while (j > i)
        {
            tempArea = height[i] < height[j] ? (j - i) * height[i] : (j - i) * height[j];
            if (tempArea > maxArea)
                maxArea = tempArea;
            i++; j--;
        }
        return maxArea;
    }
}
