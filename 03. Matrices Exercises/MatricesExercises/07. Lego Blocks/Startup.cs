using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lego_Blocks
{
    class Startup
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var lego = new List<int>[rows];

            for (int row = 0; row < rows; row++)
            {
                lego[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            for (int row = 0; row < rows; row++)
            {
                lego[row].AddRange(Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToList());
            }

            if (lego.Length > 0)
            {
                var counter = 0;
                var isLegoPerfect = true;
                var correctLength = lego[0].Count;

                for (int row = 0; row < rows; row++)
                {
                    counter += lego[row].Count;

                    if (lego[row].Count != correctLength)
                    {
                        isLegoPerfect = false;
                    }
                }

                if (isLegoPerfect)
                {
                    for (int r = 0; r < rows; r++)
                    {
                        Console.WriteLine($"[{string.Join(", ", lego[r])}]");
                    }
                }
                else
                {
                    Console.WriteLine($"The total number of cells is: {counter}");
                }
            }
        }
    }
}
