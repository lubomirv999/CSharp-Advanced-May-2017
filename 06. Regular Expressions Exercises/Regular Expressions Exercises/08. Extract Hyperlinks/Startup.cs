using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Extract_Hyperlinks
{
    class Startup
    {
        private static List<String> _result;

        static void Main(string[] args)
        {
            _result = new List<String>();
            String input = GetInput();

            GetResults(input);
            PrintResults();
        }

        private static void PrintResults()
        {
            foreach (var i in _result)
            {
                Console.WriteLine(i);
            }
        }

        private static void GetResults(String input)
        {
            String pattern = @"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                if (!(match.Groups[2].Value == "fake"))
                {
                    _result.Add(match.Groups[2].Value);
                }

                match = match.NextMatch();
            }
        }

        private static String GetInput()
        {
            StringBuilder bld = new StringBuilder();

            while (true)
            {
                String input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bld.Append(input);
                bld.Append("\n");
            }

            return bld.ToString();
        }
    }
}
