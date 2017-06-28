using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatchingBrackets
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input.Split(' ');
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    string content = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(content);
                }
            }          
        }
    }
}
