using System;
using System.Linq;

namespace _02.Upper_Strings
{
    class Startup
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            words.Select(w => w.ToUpper()).ToList().ForEach(w => Console.Write(w + " "));
        }
    }
}
