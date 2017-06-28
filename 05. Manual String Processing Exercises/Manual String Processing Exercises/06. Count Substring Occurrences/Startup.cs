using System;

namespace _06.Count_Substring_Occurrences
{
    class Startup
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();

            var counter = 0;
            var index = text.IndexOf(word);

            while (index != -1)
            {
                index = text.IndexOf(word, index + 1);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
