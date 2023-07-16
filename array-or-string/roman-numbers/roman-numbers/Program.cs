using Namespace;

namespace roman_numbers;
class Program
{
    static void Main(string[] args)
    {  
        var output = $"XV = {ConvertRomanToNormalNumbers.ConvertNumber("XV")}";
        Console.WriteLine(output);

        output = $"XII = {ConvertRomanToNormalNumbers.ConvertNumber("XII")}";
        Console.WriteLine(output);

        output = $"XVII = {ConvertRomanToNormalNumbers.ConvertNumber("XVII")}";
        Console.WriteLine(output);

        output = $"III = {ConvertRomanToNormalNumbers.ConvertNumber("III")}";
        Console.WriteLine(output);

        output = $"IV = {ConvertRomanToNormalNumbers.ConvertNumber("IV")}";
        Console.WriteLine(output);

        output = $"VI = {ConvertRomanToNormalNumbers.ConvertNumber("VI")}";
        Console.WriteLine(output);

        output = $"XL = {ConvertRomanToNormalNumbers.ConvertNumber("XL")}";
        Console.WriteLine(output);

        output = $"XC = {ConvertRomanToNormalNumbers.ConvertNumber("XC")}";
        Console.WriteLine(output);

        output = $"CD = {ConvertRomanToNormalNumbers.ConvertNumber("CD")}";
        Console.WriteLine(output);

        output = $"CM = {ConvertRomanToNormalNumbers.ConvertNumber("CM")}";
        Console.WriteLine(output);

    }

}
