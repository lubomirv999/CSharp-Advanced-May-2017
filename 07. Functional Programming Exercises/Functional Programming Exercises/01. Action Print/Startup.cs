using System;

namespace _01.Action_Print
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            Action<string> result = n => Console.WriteLine(n);

            foreach (var word in input)
            {
                result(word);
            }           
        }
    }
}
