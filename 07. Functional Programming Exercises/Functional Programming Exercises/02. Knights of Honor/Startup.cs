using System;

namespace _02.Knights_of_Honor
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Action<string> result = n => Console.WriteLine("Sir " + n);

            foreach (var word in input)
            {
                result(word);
            }
        }
    }
}
