using System;
using System.Text;

namespace _08.Multiply_big_number
{
    class Startup
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var multiplier = int.Parse(Console.ReadLine());

            var num = number.TrimStart('0');

            if (multiplier == 0 || number == "0")
            {
                Console.WriteLine("0");;
                return;
            }

            var sb = new StringBuilder();
            var numInMind = 0;

            for (int i = 0; i < num.Length; i++)
            {
                var currentDigit = num[num.Length - 1 - i] - '0';

                var resultDigit = currentDigit * multiplier % 10 + numInMind;
                numInMind = 0;

                if (resultDigit >= 10)
                {
                    numInMind++;
                    resultDigit -= 10;
                }

                numInMind += currentDigit * multiplier / 10;
                sb.Insert(0, resultDigit);
            }

            if (numInMind > 0)
            {
                sb.Insert(0, numInMind);
            }

            Console.WriteLine(sb);
        }
    }
}
