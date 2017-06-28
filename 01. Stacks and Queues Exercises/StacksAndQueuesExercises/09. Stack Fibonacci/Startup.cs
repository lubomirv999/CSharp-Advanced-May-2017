using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Startup
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<long> fibonacciNumbers = new Stack<long>();

            fibonacciNumbers.Push(1);
            fibonacciNumbers.Push(1);

            for (int i = 2; i < num; i++)
            {
                long fibPrev = fibonacciNumbers.Pop();
                long fibNext = fibonacciNumbers.Peek() + fibPrev;
                fibonacciNumbers.Push(fibPrev);
                fibonacciNumbers.Push(fibNext);
            }

            Console.WriteLine(fibonacciNumbers.Peek());
        }
    }
}
