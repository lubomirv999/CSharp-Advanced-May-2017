using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class Startup
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            Action<int, int, string> printer = (start, end, evenOrOdd) =>
            {
                List<int> result = new List<int>();

                if (evenOrOdd == "even")
                {
                    for (int i = start; i <= end; i++)
                    {
                        if (i % 2 == 0)
                        {
                            result.Add(i);
                        }
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    for (int i = start; i <= end; i++)
                    {
                        if (i % 2 != 0)
                        {
                            result.Add(i);
                        }
                    }
                }

                Console.WriteLine(string.Join(" ", result));
            };

            printer(bounds[0], bounds[1], input);
        }
    }
}