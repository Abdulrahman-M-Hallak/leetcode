using Microsoft.VisualBasic;

namespace Namespace;
public static class ConvertRomanToNormalNumbers
{
    private static readonly Dictionary<char, int> _numbers = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

    public static int ConvertNumber(string romanNumber)
    {
        // Two base Cases
        if (romanNumber.Length == 0)
            return 0;
        if (romanNumber.Length == 1)
            return _numbers[romanNumber[0]];

        // Take the first two letters to check for the special case.
        var two = new String(romanNumber.Take(2).ToArray());

        // If it is a special case.
        int num = 0;
        if ((num = CalculateWhenLowBeforeHigh(two)) != 0)
            return num + ConvertNumber((new String(romanNumber.Skip(2).ToArray())));

        // Normal flow.
        return _numbers[two[0]] + ConvertNumber((new String(romanNumber.Skip(1).ToArray())));
    }
    private static int CalculateWhenLowBeforeHigh(string romanNumber) => romanNumber switch
    {
        "IV" => 4,
        "IX" => 9,
        "XL" => 40,
        "XC" => 90,
        "CD" => 400,
        "CM" => 900,
        _ => 0
    };
}
