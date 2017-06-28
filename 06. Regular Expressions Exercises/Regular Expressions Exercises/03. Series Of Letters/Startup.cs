using System;
using System.Text.RegularExpressions;

namespace _03.Series_Of_Letters
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(Regex.Replace(input, "([A-Za-z])\\1+", "$1"));
        }
    }
}
