using System;

namespace _03.Formatting_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {' ', '\r', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            int intNum = int.Parse(input[0]);
            double firstFloatNum = double.Parse(input[1]);
            double secondFloatNum = double.Parse(input[2]);

            string result = string.Format("|{0}|{1}|{2}|{3}|",
                Convert.ToString(intNum, 16).ToUpper().PadRight(10),
                Convert.ToString(intNum, 2).PadLeft(10, '0').Substring(0, 10),
                firstFloatNum.ToString("0.00").PadLeft(10),
                secondFloatNum.ToString("0.000").PadRight(10));

            Console.WriteLine(result);
        }
    }
}
