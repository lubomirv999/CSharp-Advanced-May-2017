using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Startup
    {
        static void Main(string[] args)
        {
            //var input =
            //    Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Func<int[], int> minFunc = ints => ints.Min();

            //Console.WriteLine(minFunc(input));

            var nums = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MinNum(nums);
        }

        public static void MinNum(int[] nums)
        {
            int minNum = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < minNum)
                {
                    minNum = num;

                }

                Console.WriteLine(minNum);
            }
        }
    }
