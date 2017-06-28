using System;
using System.Text.RegularExpressions;

namespace _04.Extract_Integer_Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex pattern = new Regex(@"[\d]+");

            var results = pattern.Matches(text);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
