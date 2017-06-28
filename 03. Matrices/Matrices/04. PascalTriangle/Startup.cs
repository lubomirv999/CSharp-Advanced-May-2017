﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PascalTriangle
{
    class Startup
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
            long[][] pascal = new long[height][];

            for (int row = 0; row < height; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                for (int col = 1; col < pascal[row].Length - 1; col++)
                {
                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
