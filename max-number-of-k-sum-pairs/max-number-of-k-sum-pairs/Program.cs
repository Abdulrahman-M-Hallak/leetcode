namespace max_number_of_k_sum_pairs;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(MaxOperations(new int[] { 1, 2, 3, 4 }, 5));
    }
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int i = 0, j = nums.Length - 1, numberOfOperation = 0;
        while (i > j)
        {
            int sum = nums[i] + nums[j];

            if (sum > k)
                j--;
            else if (sum < k)
                i++;
            else
            {
                numberOfOperation++;
                j--; i++;
            }
        }
        return numberOfOperation;
    }
}
