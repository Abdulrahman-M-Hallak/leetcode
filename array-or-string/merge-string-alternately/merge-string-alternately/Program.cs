using Namespace;

namespace merge_string_alternately;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var input1 = MergeStrings.Merge("abd" , "pqr");
        System.Console.WriteLine(input1);
        var input2 = MergeStrings.Merge("ab","pqrs");
        System.Console.WriteLine(input2);
        var input3 = MergeStrings.Merge("abcd","pq");
        System.Console.WriteLine(input3);
        
    }
}
