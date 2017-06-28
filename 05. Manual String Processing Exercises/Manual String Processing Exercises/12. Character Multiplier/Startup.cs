using System;

namespace _12.Character_Multiplier
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            string firstWord = input[0];
            string secondWord = input[1];
            int totalSum = 0;

            for (int i = 0; i < firstWord.Length && i < secondWord.Length; i++)
            {
                totalSum += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    totalSum += firstWord[i];
                }
            }
            else
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    totalSum += secondWord[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
