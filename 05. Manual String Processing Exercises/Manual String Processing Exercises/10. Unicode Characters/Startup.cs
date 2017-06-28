using System;
using System.Linq;

namespace _10.Unicode_Characters
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();

            foreach (var ch in input)
            {
                Console.Write(@"\u{0:x4}", (int)ch);
            }

            Console.WriteLine();
        }
    }
}
