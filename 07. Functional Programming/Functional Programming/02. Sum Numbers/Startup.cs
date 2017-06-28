using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(input
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Count());

            Console.WriteLine(input
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum());
        }
    }
}
