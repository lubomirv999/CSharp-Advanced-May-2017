using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Startup
    {
        static void Main(string[] args)
        {
            int numOfElements = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < numOfElements; i++)
            {
                var input = Console.ReadLine().Split(' ');

                foreach (var element in input)
                {
                    elements.Add(element);
                }             
            }

            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
        }
    }
}
