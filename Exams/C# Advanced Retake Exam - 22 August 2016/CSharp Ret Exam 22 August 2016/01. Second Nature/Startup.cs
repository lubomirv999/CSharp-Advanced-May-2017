using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Second_Nature
{
    class Startup
    {
        static void Main(string[] args)
        {
            Stack<int> flowers = new Stack<int>
            (
                Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
            );

            Stack<int> buckets = new Stack<int>
            (
                Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
            );

            Queue<int> secondNatureFlower = WaterFlowers(flowers, buckets);
            PrintResult(buckets, secondNatureFlower, flowers);
        }

        private static Queue<int> WaterFlowers(Stack<int> flowers, Stack<int> buckets)
        {
            var secondNatureFlower = new Queue<int>();

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                if (buckets.Peek() < flowers.Peek())
                {
                    flowers.Push(flowers.Pop() - buckets.Pop());
                }
                else if (buckets.Peek() == flowers.Peek())
                {
                    secondNatureFlower.Enqueue(flowers.Pop());
                    buckets.Pop();
                }
                else
                {
                    GetBackRemainingWater(buckets.Pop() - flowers.Pop(), buckets);
                }
            }

            return secondNatureFlower;
        }

        private static void GetBackRemainingWater(int remainintWater, Stack<int> water)
        {
            if (remainintWater > 0)
            {
                if (water.Any())
                {
                    water.Push(water.Pop() + remainintWater);
                }
                else
                {
                    water.Push(remainintWater);
                }
            }
        }

        private static void PrintResult(Stack<int> water, Queue<int> secondNatureFlower, Stack<int> dust)
        {
            Console.WriteLine((water.Any()) ? string.Join(" ", water) : string.Join(" ", dust));

            Console.WriteLine((secondNatureFlower.Any()) ? string.Join(" ", secondNatureFlower) : "None");
        }
    }
}