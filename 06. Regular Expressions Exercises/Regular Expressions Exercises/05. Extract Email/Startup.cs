using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Extract_Email
{
    class Startup
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            string pattern = "^|\\s[a-z0-9][\\.\\\\_\\-a-z0-9]*[a-z0-9]@[a-z0-9][\\.\\-a-z0-9]*[a-z0-9]\\.[a-z]{2,}";

            Regex regex = new Regex(pattern);            

            StringBuilder input = new StringBuilder();

            while (inputLine.ToUpper() != "END")
            {
                input.AppendLine(inputLine);
                inputLine = Console.ReadLine();
            }

            MatchCollection matches = regex.Matches(input.ToString());

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                result.AppendLine(match.Value.Trim());
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
