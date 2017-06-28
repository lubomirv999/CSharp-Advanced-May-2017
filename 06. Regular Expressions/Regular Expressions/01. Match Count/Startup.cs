using System;
using System.Text.RegularExpressions;

namespace _01.Match_Count
{
    class Startup
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            Regex regex = new Regex(word);
            int count = regex.Matches(text).Count;

            Console.WriteLine(count);
        }
    }
}
