using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<string> stack = new Stack<string>(input.Split(' '));

            while(stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
