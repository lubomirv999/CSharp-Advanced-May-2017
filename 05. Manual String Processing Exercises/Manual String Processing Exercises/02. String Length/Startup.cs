using System;

namespace _02.String_Length
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine(); ;

            if (input.Length <= 20)
            {
                var result = input.PadRight(20, '*');
                Console.WriteLine(result);
            }
            else
            {
                var result = input.Substring(0, 20).PadRight(20, '*');
                Console.WriteLine(result);
            }
        }
    }
}
