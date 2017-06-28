using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Maximal_Sum
{
    class Startup
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new [] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = sizeOfMatrix[0];
            var cols = sizeOfMatrix[1];
            int[][] matrix = new int[rows][];

            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    var sum = matrix[row + 0][col] + matrix[row + 0][col + 1] + matrix[row + 0][col + 2] +
                              matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                              matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int index = maxRowIndex; index <= maxRowIndex + 2; index++)
            {
                for (int j = maxColIndex; j <= maxColIndex + 2; j++)
                {
                    Console.Write($"{matrix[index][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
