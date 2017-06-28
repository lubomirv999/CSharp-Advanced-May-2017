using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Extract_Quotations
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex pattern = new Regex("(\"|')(.*?)\\1");

            var matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
