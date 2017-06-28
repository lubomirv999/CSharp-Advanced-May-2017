using System;
using System.Text.RegularExpressions;

namespace _06.Sentence_Extractor
{
    class Startup
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = ".+?(\\!|\\.|\\?)";          

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                if (Regex.IsMatch(match.Value, $@"\b{word}\b"))
                {
                    Console.WriteLine(match.Value.Trim());
                }
            }
        }
    }
}
