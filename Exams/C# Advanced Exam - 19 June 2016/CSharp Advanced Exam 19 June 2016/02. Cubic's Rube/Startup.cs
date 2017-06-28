using System;
using System.Linq;

namespace _02.Cubic_s_Rube
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfDimensions = int.Parse(Console.ReadLine());

            long sum = 0;
            var changedCells = 0;
            string input;

            while ((input = Console.ReadLine()) != "Analyze")
            {
                var tokens = input.Split(' ').Select(int.Parse).ToArray();

                if (tokens.Take(3).Any(n => n < 0 || n >= numberOfDimensions))
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sum += tokens[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(Math.Pow(numberOfDimensions, 3) - changedCells);
        }
    }
}