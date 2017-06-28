using System;
using System.Linq;

namespace _04.Average_of_Doubles
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList().Average();

            Console.WriteLine($"{numbers:F2}");
        }
    }
}
