using System;

namespace _09.Text_Filter
{
    class Startup
    {
        static void Main(string[] args)
        {
            var banList = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var banWord in banList)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
