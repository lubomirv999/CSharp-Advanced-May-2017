using System.Linq;

namespace _03.Word_Count
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            var words = new Dictionary<string, int>();
            var reader = new StreamReader("../../words.txt");

            using (reader)
            {
                var line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    var tokens = Regex.Split(line.ToLower(), @"\W+");

                    foreach (var word in tokens)
                    {
                        words[word] = 0;
                    }
                }

                var textReader = new StreamReader("../../text.txt");

                using (textReader)
                {
                    line = string.Empty;

                    while ((line = textReader.ReadLine()) != null)
                    {
                        var tokens = Regex.Split(line.ToLower(), @"\W+");

                        foreach(var word in tokens)
                        {
                            if (words.ContainsKey(word))
                            {
                                words[word]++;
                            }
                        }
                    }
                }

                var writer = new StreamWriter("../../result.txt");

                using (writer)
                {
                    var sortedWords = words.OrderByDescending(w => w.Value);

                    foreach (var word in sortedWords)
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }

            

        }
    }
}
