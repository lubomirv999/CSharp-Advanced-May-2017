﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Sum_big_numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var firstNum = new Stack<char>(Console.ReadLine());
            var secondNum = new Stack<char>(Console.ReadLine());

            var result = new StringBuilder();
            var sum = 0;

            while (firstNum.Count != 0 || secondNum.Count != 0)
            {
                sum = sum / 10;

                if (firstNum.Count != 0) sum += int.Parse(firstNum.Pop().ToString());
                if (secondNum.Count != 0) sum += int.Parse(secondNum.Pop().ToString());

                result.Insert(0, sum % 10);
            }

            result.Insert(0, sum / 10);

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
