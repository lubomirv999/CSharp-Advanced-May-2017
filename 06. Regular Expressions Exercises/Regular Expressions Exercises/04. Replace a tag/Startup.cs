using System;
using System.Text.RegularExpressions;

namespace _04.Replace_a_tag
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"<a (href=.+?)>(.+)</a>");           

            while (input != "end")
            {
                Console.WriteLine(Regex.Replace(input, regex.ToString(),
                    @"[URL $1]$2[/URL]"));

                input = Console.ReadLine();
            }
        }
    }
}
