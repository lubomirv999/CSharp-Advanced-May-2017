using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleCalculator
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var reminder = input.Split(' ');
            Stack<string> stack = new Stack<string>(reminder.Reverse());

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondSum = int.Parse(stack.Pop());
            
                if (op == "+")
                {
                    stack.Push((firstNum + secondSum).ToString());
                }
                else
                {
                    stack.Push((firstNum - secondSum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
