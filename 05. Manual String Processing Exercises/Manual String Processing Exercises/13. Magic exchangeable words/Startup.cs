using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Magic_exchangeable_words
{
    class Startup
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Trim().Split();
            //HashSet<char> firstWord = new HashSet<char>(input[0]);
            //HashSet<char> secondWord = new HashSet<char>(input[1]);
            //Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
            //Simple Solution ------------------------

            var input = Console.ReadLine().Split(' ');

            var longerWord = string.Empty;
            var shorterWord = string.Empty;

            if (input[0].Length > input[1].Length)
            {
                longerWord = input[0];
                shorterWord = input[1];
            }
            else
            {
                longerWord = input[1];
                shorterWord = input[0];
            }

            var newAlphabet = new Dictionary<char, char>();

            var isExchangeable = true;
            if (longerWord.Length == shorterWord.Length)
            {
                for (int i = 0; i < shorterWord.Length; i++)
                {
                    var currentFirstChar = shorterWord[i];
                    var currentSecondChar = longerWord[i];

                    if (newAlphabet.ContainsKey(currentFirstChar))
                    {
                        if (newAlphabet[currentFirstChar] != currentSecondChar)
                        {
                            isExchangeable = false;
                        }
                    }
                    else
                    {
                        newAlphabet[currentFirstChar] = currentSecondChar;
                    }
                }

            }
            else
            {
                for (int i = 0; i < shorterWord.Length; i++)
                {
                    var currentFirstChar = shorterWord[i];
                    var currentSecondChar = longerWord[i];

                    if (newAlphabet.ContainsKey(currentFirstChar))
                    {
                        if (newAlphabet[currentFirstChar] != currentSecondChar)
                        {
                            isExchangeable = false;
                        }
                    }
                    else
                    {
                        newAlphabet[currentFirstChar] = currentSecondChar;
                    }
                }

                for (int i = shorterWord.Length + 1; i < longerWord.Length; i++)
                {
                    var currentFirstChar = longerWord[i];

                    if (!newAlphabet.ContainsValue(currentFirstChar))
                    {
                        isExchangeable = false;
                    }
                }
            }

            if (newAlphabet.Values.Distinct().Count() != newAlphabet.Values.Count())
            {
                isExchangeable = false;
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
