namespace move_zeros;
class Program
{
    static void Main(string[] args)
    {
        MoveZeros(new int[] { 0, 1, 0, 3, 12 });
    }
    public static void MoveZeros(int[] nums)
    {
        int j = 0, i = 0;
        var output = new int[nums.Length];
        while (i < nums.Length)
        {
            if (nums[i] != 0)
            {
                output[j] = nums[i];
                nums[i] = 0;
                j++; i++;
                continue;
            }
            i++;
        }
        nums = output;
    }
}
