using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Startup
    {
        static void Main(string[] args)
        {
            var queriesNumbers = int.Parse(Console.ReadLine());

            Stack<int> nums = new Stack<int>();
            Stack<int> maxNums = new Stack<int>();
            var maxValue = int.MinValue;

            for (int i = 0; i < queriesNumbers; i++)
            {
                var query = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (query[0] == 1)
                {
                    nums.Push(query[1]);
                    if (maxValue < query[1])
                    {
                        maxValue = query[1];
                        maxNums.Push(maxValue);
                    }
                }
                else if (query[0] == 2)
                {
                    if (nums.Pop() == maxValue)
                    {
                        maxNums.Pop();
                        if (maxNums.Count != 0)
                        {
                            maxValue = maxNums.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                    }               
                }
                else if (query[0] == 3)
                {
                    Console.WriteLine(maxValue);
                }
            }          
        }
    }
}
