namespace increasing_triplets;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var ints = new[] { 100,100,100,100,100,0,0,0,0,60,61,62};
        System.Console.WriteLine(IncreasingTriplets(ints));
    }
    public static bool IncreasingTriplets(int[] nums)
    {
        var leftMin = new int[nums.Length];
        leftMin[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
            leftMin[i] = Math.Min(leftMin[i - 1], nums[i]);

        var rightMax = new int[nums.Length];
        rightMax[nums.Length - 1] = nums[^1];

        for (int i = nums.Length - 2; i >= 0; i--)
            rightMax[i] = Math.Max(rightMax[i + 1], rightMax[i]);

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftMin[i] < nums[i] && nums[i] < rightMax[i])
            return true;
        }
        return false;
    }
}
