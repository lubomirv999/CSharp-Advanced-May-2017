using System;
using System.Linq;

namespace _03.First_Name
{
    class Startup
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            var letters = Console.ReadLine().Split(' ').OrderBy(w => w);

            foreach (var letter in letters)
            {
                var result = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}
