using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Crossfire
{
    class Startup
    {
        public static int Rows;
        public static int Cols;
        public static List<List<long>> Matrix;

        public static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Rows = dimentions[0];
            Cols = dimentions[1];

            string input = Console.ReadLine();
            FillMatrix();

            while (input != "Nuke it from orbit")
            {
                var command = input.Split();
                int cellRow = int.Parse(command[0]);
                int cellCol = int.Parse(command[1]);
                int radius = int.Parse(command[2]);

                Nuke(cellRow, cellCol, radius);
                ReorderMatrix();

                input = Console.ReadLine();
            }
            PrintMatrix();
        }

        public static void FillMatrix()
        {
            Matrix = new List<List<long>>();
            int count = 1;

            for (int i = 0; i < Rows; i++)
            {
                Matrix.Add(new List<long>());

                for (int k = 0; k < Cols; k++)
                {
                    Matrix[i].Add(count);
                    count++;
                }
            }
        }

        public static void Nuke(int row, int col, int radius)
        {
            for (int i = col - radius; i <= col + radius; i++)
            {
                if (isInMatrix(row, i))
                {
                    Matrix[row][i] = 0;
                }
            }

            for (int i = row - radius; i <= row + radius; i++)
            {
                if (isInMatrix(i, col))
                {
                    Matrix[i][col] = 0;
                }
            }
        }

        public static bool isInMatrix(int row, int col)
        {
            int matrixRows = Matrix.Count;

            if (row < 0 || row >= matrixRows)
            {
                return false;
            }
            else
            {
                int matrixCols = Matrix[row].Count;

                if (col < 0 || col >= matrixCols)
                {
                    return false;
                }
            }

            return true;
        }

        public static void ReorderMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int k = Matrix[i].Count - 1; k >= 0; k--)
                {
                    if (Matrix[i][k] == 0)
                    {
                        Matrix[i].RemoveAt(k);
                    }
                }

                if (Matrix[i].Count == 0)
                {
                    Matrix.RemoveAt(i);
                    i--;
                }
            }
        }

        public static void PrintMatrix()
        {
            if (Matrix.Count != 0)
            {
                for (int i = 0; i < Matrix.Count; i++)
                {
                    var row = string.Join(" ", Matrix[i]);

                    if (row.Length == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(row);
                }
            }
        }
    }
}