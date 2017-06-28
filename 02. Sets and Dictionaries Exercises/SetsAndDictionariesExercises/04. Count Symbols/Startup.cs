using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var letters = new SortedDictionary<char, int>();

            foreach (var letter in input)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 1);
                }
                else
                {
                    letters[letter]++;
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
