namespace maximum_average_array;
class Program
{
    static void Main(string[] args)
    {
        FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
    }
    public static double FindMaxAverage(int[] nums, int k)
    {
        double maxAverage = 0, windowSum = 0;

        for (int i = 0; i < k; i++)
            windowSum += nums[i];

        maxAverage = windowSum / k;

        for (int i = k; i < nums.Length; i++)
        {
            windowSum += nums[i] - nums[i - k];
            if ((windowSum / k) > maxAverage)
                maxAverage = windowSum / k;
        }
        return maxAverage;
    }
}
