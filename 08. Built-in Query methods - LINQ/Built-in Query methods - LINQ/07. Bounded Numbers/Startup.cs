using System;
using System.Linq;

namespace _07.Bounded_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse)
                .Where(n => bounds.Min() <= n && n <= bounds.Max()).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
