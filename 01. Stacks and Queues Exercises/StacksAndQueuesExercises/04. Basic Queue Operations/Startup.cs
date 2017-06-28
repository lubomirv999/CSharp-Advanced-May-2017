using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int numsToPop = int.Parse(input[1]);
            string numToCheck = input[2];
            var smallestNum = int.MaxValue;

            var numbers = Console.ReadLine().Split(' ');

            Queue<string> nums = new Queue<string>(numbers);

            for (int i = 0; i < numsToPop; i++)
            {
                nums.Dequeue();
            }

            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (nums.Contains(numToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
