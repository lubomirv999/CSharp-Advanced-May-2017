using System;
using System.Collections.Generic;

namespace _11.Palindromes
{
    class Startup
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '?', '!' };
            var input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> result = new SortedSet<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
