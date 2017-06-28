using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    class Startup
    {
        static void Main(string[] args)
        {         
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var input = Console.ReadLine().Split().Select(byte.Parse).ToArray();           
            var matrix = new string[input[0]][];

            for (int row = 0; row < input[0]; row++)
            {
                matrix[row] = new string[input[1]];

                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row][col] = $"{alphabet[row]}{alphabet[row + col]}{alphabet[row]}";
                }
            }

            for (int row = 0; row < input[0]; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

            //char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //var input = Console.ReadLine().Split().Select(byte.Parse).ToArray();
            //var matrix = new string[input[0], input[1]];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = row, cols = 0; cols < matrix.GetLength(1); col++, cols++)
            //    {
            //        matrix[row, cols] = $"{alphabet[row]}{alphabet[col]}{alphabet[row]}";
            //    }
            //}

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }

            //    Console.WriteLine();
            //}

            //-- Seconds Solution -----------------------------------
            //string[] inputArgs = Console.ReadLine().Split(' ');
            //int rows = int.Parse(inputArgs[0]);
            //int cols = int.Parse(inputArgs[1]);

            //char startChar = 'a';

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        char leftRightChar = (char)startChar;
            //        char middleChar = (char)(startChar + col);
            //        Console.Write($"{leftRightChar}{middleChar}{leftRightChar} ");
            //    }

            //    startChar++;
            //    Console.WriteLine();
            //}
        }
    }
}
