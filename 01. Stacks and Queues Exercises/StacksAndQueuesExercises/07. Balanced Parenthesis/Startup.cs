using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Balanced_Parenthesis
{
    class Startup
    {
        static void Main(string[] args)
        {
            var paranthesisLine = Console.ReadLine();
            var openingCases = new char[] { '{', '[', '(' };
            var mismatch = false;

            Stack<char> openedParanthesis = new Stack<char>();

            for (int i = 0; i < paranthesisLine.Length; i++)
            {
                if (openingCases.Contains(paranthesisLine[i]))
                {
                    openedParanthesis.Push(paranthesisLine[i]);
                }
                else
                {
                    if (openedParanthesis.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (paranthesisLine[i])
                    {
                        case '}':
                            if (openedParanthesis.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParanthesis.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParanthesis.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
