using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Concatenate_Strings
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfRows = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            for (int i = 0; i < numberOfRows; i++)
            {
                var input = Console.ReadLine();
                result.Append(input).Append(" ");
            }
           
            Console.WriteLine(result);
        }
    }
}
