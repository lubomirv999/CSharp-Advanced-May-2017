using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Semantic_HTML
{
    class Startup
    {
        private const string openingTagPattern = @"<\s*div\s+[^>]*?(id\s*=\s*""(main|header|nav|article|section|aside|footer)""|class\s*=\s*""(main|header|nav|article|section|aside|footer)"")[^>]*?>";
        private const string closingTagPattern = @"<\/div\s*>\s*<!--\s*(main|header|nav|article|section|aside|footer)\s*-->";

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex openingTagRegex = new Regex(openingTagPattern);
            Regex closingTagRegex = new Regex(closingTagPattern);
            StringBuilder resultHtml = new StringBuilder();

            while (inputLine != "END")
            {
                if (openingTagRegex.IsMatch(inputLine))
                {
                    Match match = openingTagRegex.Match(inputLine);

                    if (match.Groups[3].Value != string.Empty)
                    {
                        string currentMatch = match.Groups[0].Value;
                        string resultHtmlTag = match.Groups[0].Value.Replace(" " + match.Groups[1].Value, "");
                        resultHtmlTag = resultHtmlTag.Replace("<div", "<" + match.Groups[3].Value);
                        resultHtmlTag = Regex.Replace(resultHtmlTag, @"\s+", " ");
                        resultHtmlTag = Regex.Replace(resultHtmlTag, @"\s*>", ">");
                        inputLine = inputLine.Replace(currentMatch, resultHtmlTag);
                    }
                    else
                    {
                        string currentMatch = match.Groups[0].Value;
                        string resultHtmlTag = match.Groups[0].Value.Replace(" " + match.Groups[1].Value, "");
                        resultHtmlTag = resultHtmlTag.Replace("<div", "<" + match.Groups[2].Value);
                        resultHtmlTag = Regex.Replace(resultHtmlTag, @"\s+", " ");
                        resultHtmlTag = Regex.Replace(resultHtmlTag, @"\s*>", ">");
                        inputLine = inputLine.Replace(currentMatch, resultHtmlTag);
                    }
                }
                else if (closingTagRegex.IsMatch(inputLine))
                {
                    Match match = closingTagRegex.Match(inputLine);

                    inputLine = inputLine.Replace(match.Groups[0].Value, $"</{match.Groups[1].Value}>");
                }

                resultHtml.AppendLine(inputLine);
                inputLine = Console.ReadLine();
            }

            Console.Write(resultHtml);
        }
    }
}
