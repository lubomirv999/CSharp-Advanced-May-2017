using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int numsToPop = int.Parse(input[1]);
            int numToSearch = int.Parse(input[2]);

            var numbers = Console.ReadLine().Split(' ');

            Stack<string> nums = new Stack<string>(numbers);

            for (int i = 0; i < numsToPop; i++)
            {
                nums.Pop();
            }

            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!nums.Contains(numToSearch.ToString()))
            {
                Console.WriteLine(nums.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
