using System;
using System.Text.RegularExpressions;

namespace _05.Extract_Tags
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex pattern = new Regex(@"<.+?>");

            while (input != "END")
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
