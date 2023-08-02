namespace find_the_difference_of_two_array;
class Program
{
    static void Main(string[] args)
    {
    }
    public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        return new List<IList<int>>()
        {
            nums1.ToHashSet().Where(x => !nums2.Contains(x)).ToList(),
            nums2.ToHashSet().Where(x => !nums1.Contains(x)).ToList()
        };
    }
}
