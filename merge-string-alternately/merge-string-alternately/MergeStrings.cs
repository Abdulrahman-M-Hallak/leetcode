using System.Text;

namespace Namespace;
public static class MergeStrings
{
    public static StringBuilder Merge(string input1, string input2)
    {
        var mergedtext = new StringBuilder();
        if (input1.Length >= input2.Length)
        {
            int i = 0;
            for (i = 0; i < input2.Length; i++)
            {
                mergedtext.Append(input1[i]);
                mergedtext.Append(input2[i]);
            }
            mergedtext.Append(input1[i..]);
        }
        else
        {
            int i = 0;
            for (i = 0; i < input1.Length; i++)
            {
                mergedtext.Append(input1[i]);
                mergedtext.Append(input2[i]);
            }
            mergedtext.Append(input2[i..]);
        }
        return mergedtext;
    }
}
