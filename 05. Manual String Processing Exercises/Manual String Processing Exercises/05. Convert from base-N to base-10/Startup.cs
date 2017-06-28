using System;
using System.Numerics;

namespace _05.Convert_from_base_N_to_base_10
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var targetBase = ulong.Parse(input[0]);
            var number = input[1];
            var result = new BigInteger();

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger currentDigit = number[i] - '0';
                result += BigInteger.Parse((currentDigit * BigInteger.Pow(targetBase, number.Length - i - 1)).ToString());
            }

            Console.WriteLine(result);
        }
    }
}
