using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Ashes_of_Roses
{
    class Startup
    {
        static void Main(string[] args)
        {
            var pattern = "^Grow\\s<([A-Z][a-z]+)>\\s<([A-Za-z0-9]+)>\\s([0-9]+)$";

            var inputLine = Console.ReadLine();
            var rosesDictionary = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "Icarus, Ignite!")
            {
                var regex = new Regex(pattern);
                var match = regex.Match(inputLine);

                if (!match.Success)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                FillTheRoseDict(rosesDictionary, match);

                inputLine = Console.ReadLine();
            }
            Print(rosesDictionary);
        }

        private static void Print(Dictionary<string, Dictionary<string, long>> rosesDictionary)
        {
            var orderedRegions = rosesDictionary.OrderByDescending(pair => pair.Value.Values.Sum()).ThenBy(pair => pair.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedRegions)
            {
                var region = pair.Key;
                var colorsOfRose = pair.Value;
                var orderedColor = colorsOfRose.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"{region}");
                foreach (var nestedPair in orderedColor)
                {
                    var color = nestedPair.Key;
                    var ammountOfRose = nestedPair.Value;
                    Console.WriteLine($"*--{color} | {ammountOfRose}");
                }

            }
        }

        private static void FillTheRoseDict(Dictionary<string, Dictionary<string, long>> rosesDictionary, Match match)
        {
            var regionName = match.Groups[1].ToString();
            var colorType = match.Groups[2].ToString();
            var amountOfRoses = int.Parse(match.Groups[3].ToString());

            if (!rosesDictionary.ContainsKey(regionName))
            {
                rosesDictionary.Add(regionName, new Dictionary<string, long>());
                rosesDictionary[regionName].Add(colorType, amountOfRoses);
            }
            else
            {
                if (!rosesDictionary[regionName].ContainsKey(colorType))
                {
                    rosesDictionary[regionName].Add(colorType, amountOfRoses);
                }
                else
                {
                    rosesDictionary[regionName][colorType] += amountOfRoses;
                }
            }
        }
    }
}