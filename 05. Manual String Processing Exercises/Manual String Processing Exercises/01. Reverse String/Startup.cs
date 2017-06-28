using System;

namespace _01.Reverse_String
{
    class Startup
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);

            Console.WriteLine(input);
        }
    }
}
