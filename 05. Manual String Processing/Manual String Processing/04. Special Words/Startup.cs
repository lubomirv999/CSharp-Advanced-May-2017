using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Special_Words
{
    class Startup
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '{', '}', '[', ']', '<', '>', ',','-', '!', '?', ' ' };

            var specialWords = Console.ReadLine().Split(separators);
            var text = Console.ReadLine().Split(separators);

            foreach (var word in specialWords)
            {
                int count = 0;

                foreach (var w in text)
                {
                    if (word == w)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{word} - {count}");
            }

        }
    }
}
