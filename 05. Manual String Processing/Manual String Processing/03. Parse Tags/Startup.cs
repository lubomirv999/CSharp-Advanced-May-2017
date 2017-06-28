using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parse_Tags
{
    class Startup
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = text.IndexOf(openTag);

            while (startIndex != -1)
            {
                int endIndex = text.IndexOf(closeTag);

                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = text.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var replaced = toBeReplaced.Replace(openTag, String.Empty).Replace(closeTag, String.Empty).ToUpper();

                text = text.Replace(toBeReplaced, replaced);

                startIndex = text.IndexOf(openTag);
            }

            Console.WriteLine(text);
        }
    }
}
