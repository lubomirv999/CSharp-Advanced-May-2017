using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Target_Practice
{
    class Startup
    {
        static bool isInside(int shootX, int shootY, int targetX, int targetY, int radius)
        {
            var distance = Math.Sqrt(Math.Pow(shootX - targetX, 2) + Math.Pow(shootY - targetY, 2));

            if (distance <= radius)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var snake = Console.ReadLine();
            var matrix = new char[rows][];

            var counter = 0;
            bool fromRight = true;

            for (int row = rows - 1; row >= 0; row--)
            {
                matrix[row] = new char[cols];

                if (fromRight)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row][col] = snake[counter % snake.Length];
                        counter++;
                    }

                    fromRight = false;
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row][col] = snake[counter % snake.Length];
                        counter++;
                    }

                    fromRight = true;
                }
            }
            var shoot = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var shootX = shoot[0];
            var shootY = shoot[1];
            var shootRadius = shoot[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (isInside(row, col, shootX, shootY, shootRadius))
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

            bool proceed = false;

            do
            {
                proceed = false;
                for (int row = 0; row < rows - 1; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if ((matrix[row][col] != ' ') && (matrix[row + 1][col] == ' '))
                        {
                            proceed = true;
                            matrix[row + 1][col] = matrix[row][col];
                            matrix[row][col] = ' ';
                        }
                    }
                }
            } while (proceed);

            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine(string.Join("", matrix[r]));
            }
        }
    }
}
