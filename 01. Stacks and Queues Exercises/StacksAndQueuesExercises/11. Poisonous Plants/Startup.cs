﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Poisonous_Plants
{
    class Startup
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] days = new int[num];
            var stack = new Stack<int>();

            stack.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;
                stack.Push(i);

                while (stack.Count > 0 && plants[stack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[stack.Pop()]);
                }

                if (stack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                stack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
