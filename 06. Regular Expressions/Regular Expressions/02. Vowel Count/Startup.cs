using System;
using System.Text.RegularExpressions;

namespace _02.Vowel_Count
{
    class Startup
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex pattern = new Regex("[AEIOUYaeiouy]");

            var count = pattern.Matches(text).Count;

            Console.WriteLine($"Vowels: {count}");
        }
    }
}
