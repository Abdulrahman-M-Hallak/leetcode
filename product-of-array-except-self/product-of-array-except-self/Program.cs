namespace product_of_array_except_self;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ProductExceptSelf(new int[] { 1, 2, 3,4});
    }
    public static int[] ProductExceptSelf(int[] nums)
    {
        var arrLength = nums.Length;
        var output = new int[arrLength];
    
        for (int i = 0, prev = 1; i < arrLength; i++)
        {
            output[i] = prev;
            prev = nums[i] * prev;
        }
    
        for (int i = arrLength - 1, prev = 1; i >= 0; i--)
        {
            output[i] = output[i] * prev;
            prev = nums[i] * prev;
        }
        return output;
    }
}
