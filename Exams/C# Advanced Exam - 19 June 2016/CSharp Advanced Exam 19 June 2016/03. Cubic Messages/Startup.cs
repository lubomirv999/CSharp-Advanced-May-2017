using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Cubic_Messages
{
    class Startup
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"(^\d+)([a-zA-Z]+)([^a-zA-Z]*$)");
            string input;

            while ((input = Console.ReadLine()) != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());
                var match = pattern.Match(input);

                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var ending = String.Empty;

                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;
                    }

                    if (message.Length != messageLength)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*",String.Empty);

                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        var ind = int.Parse(index.ToString());

                        if (ind >= 0 && ind < messageLength)
                        {
                            sb.Append(message[ind]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }

                    Console.WriteLine($"{message} == {sb}");
                }
            }
        }
    }
}
