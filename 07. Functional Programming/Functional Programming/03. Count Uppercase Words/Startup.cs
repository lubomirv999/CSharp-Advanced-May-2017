using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            input.Where(checker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
