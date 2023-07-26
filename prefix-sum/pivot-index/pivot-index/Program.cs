namespace pivot_index;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int PivotIndex(int[] nums)
    {
        int rightSum = nums.Sum(), leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            if (leftSum == rightSum)
                return i;
            leftSum += nums[i];
        }
        return -1;
    }
}
