using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubiks_Matrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = sizeOfMatrix[0];
            var cols = sizeOfMatrix[1];
            var matrix = new int[rows][];

            var shuffles = int.Parse(Console.ReadLine());          
            var counter = 1;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];

                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = counter++;
                }
            }

            for (int i = 0; i < shuffles; i++)
            {
                var data = Console.ReadLine().Split().ToArray();
                var target = int.Parse(data[0]);
                var command = data[1];
                var shifts = int.Parse(data[2]);
                var buffer = 9999999;

                if (command == "down")
                {
                    shifts = shifts % rows;

                    for (int j = 0; j < shifts; j++)
                    {
                        for (int r = 0; r < rows; r++)
                        {
                            var cur = matrix[r][target];
                            matrix[r][target] = buffer;
                            buffer = cur;
                        }

                        matrix[0][target] = buffer;
                    }
                }

                if (command == "up")
                {
                    shifts = shifts % rows;

                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[0][target];

                        for (int r = 0; r < rows - 1; r++)
                        {
                            matrix[r][target] = matrix[r + 1][target];
                        }

                        matrix[matrix.Length - 1][target] = buffer;
                    }
                }

                if (command == "left")
                {
                    shifts = shifts % cols;

                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[target][0];

                        for (int c = 0; c < cols - 1; c++)
                        {
                            matrix[target][c] = matrix[target][c + 1];
                        }

                        matrix[target][matrix[target].Length - 1] = buffer;
                    }
                }

                if (command == "right")
                {
                    shifts = shifts % cols;

                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[target][0];

                        for (int c = 1; c < cols; c++)
                        {
                            var curr = matrix[target][c];
                            matrix[target][c] = buffer;
                            buffer = curr;
                        }

                        matrix[target][0] = buffer;
                    }
                }
            }

            counter = 1;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] != counter)
                    {
                        for (int rr = 0; rr < rows; rr++)
                        {
                            for (int cc = 0; cc < cols; cc++)
                            {
                                if (matrix[rr][cc] == counter)
                                {
                                    var wrong = matrix[r][c];
                                    var correct = matrix[rr][cc];

                                    matrix[r][c] = correct;
                                    matrix[rr][cc] = wrong;

                                    Console.WriteLine($"Swap ({r}, {c}) with ({rr}, {cc})");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                    counter++;
                }
            }
        }
    }
}
