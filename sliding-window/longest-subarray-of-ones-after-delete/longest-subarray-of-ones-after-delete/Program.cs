namespace longest_subarray_of_ones_after_delete;
class Program
{
    static void Main(string[] args)
    {
        LongestSubArray(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 });
    }
    public static int LongestSubArray(int[] nums)
    {
        int zeroCount = 0, left = 0, longest = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            zeroCount += nums[i] == 0 ? 1 : 0;
            if (zeroCount > 1)
            {
                zeroCount += nums[left] == 0 ? -1 : 0;
                left++;
            }
            else
                longest = Math.Max(i - left, longest);
        }
        return longest;
    }
}
