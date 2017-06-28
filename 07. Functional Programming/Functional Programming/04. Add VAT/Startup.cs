using System;
using System.Linq;

namespace _04.Add_VAT
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *= 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:n2}"));
        }
    }
}
