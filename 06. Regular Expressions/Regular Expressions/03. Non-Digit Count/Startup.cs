using System;
using System.Text.RegularExpressions;

namespace _03.Non_Digit_Count
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex pattern = new Regex("[^0-9]");

            var count = pattern.Matches(input).Count;

            Console.WriteLine($"Non-digits: {count}");
        }
    }
}
