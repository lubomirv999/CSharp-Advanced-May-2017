using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _09.Query_Mess
{
    class Startup
    {
        private const string encodedSpacesPattern = @"\+|%20";
        private const string keyValuePairsPattern = @"(([^?]+?)=([^?]+?)($|&))";

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                MatchCollection matches = Regex.Matches(inputLine, keyValuePairsPattern);

                var keyValuePairs = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups[2].Value;
                    string value = match.Groups[3].Value;

                    key = ReplaceEncodedSpaces(key);
                    value = ReplaceEncodedSpaces(value);

                    if (!keyValuePairs.ContainsKey(key))
                    {
                        keyValuePairs.Add(key, new List<string>());
                    }

                    keyValuePairs[key].Add(value);
                }

                foreach (var kvp in keyValuePairs)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
                inputLine = Console.ReadLine();
            }
        }

        private static string ReplaceEncodedSpaces(string value)
        {
            string decodedSpaces = Regex.Replace(value, encodedSpacesPattern, " ").Trim();
            return Regex.Replace(decodedSpaces, @"\s{1,}", " ");
        }
    }
}
