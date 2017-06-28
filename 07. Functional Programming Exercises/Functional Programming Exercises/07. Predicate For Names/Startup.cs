using System;

namespace _07.Predicate_For_Names
{
    class Startup
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> filter = x => x.Length <= n;

            foreach (var name in names)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
