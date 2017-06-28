using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_Of_Elements
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var firstNum = int.Parse(input[0]);
            var secondNum = int.Parse(input[1]);

            var firstNums = new HashSet<int>();
            var secondNums = new HashSet<int>();

            for (int i = 0; i < firstNum; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstNums.Add(num);
            }

            for (int i = 0; i < secondNum; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondNums.Add(num);
            }

            foreach (var item in firstNums)
            {
                if (secondNums.Contains(item))
                {
                    Console.WriteLine(item + " ");
                }               
            }                    
        }
    }
}
