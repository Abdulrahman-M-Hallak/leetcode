namespace max_consecutive_ones;
class Program
{
    static void Main(string[] args)
    {
        LongestOnes(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2);
    }
    public static int LongestOnes(int[] nums, int k)
    {
        int left = 0, longestOnes = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            k += nums[right] == 0 ? -1 : 0;
            if (k < 0)
            {
                k += nums[left] == 0 ? 1 : 0;
                left++;
            }
            else
            {
                longestOnes = Math.Max(longestOnes, right - left + 1);
            }
        }
        return longestOnes;
    }
}
