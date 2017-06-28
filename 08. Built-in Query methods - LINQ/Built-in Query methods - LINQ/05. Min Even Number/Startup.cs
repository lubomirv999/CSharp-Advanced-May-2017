using System;
using System.Linq;

namespace _05.Min_Even_Number
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToList();

            if (numbers.Count >= 1)
            {
                var result = numbers.Min();
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine("No match");
            }          
        }
    }
}
