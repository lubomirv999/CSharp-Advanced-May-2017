using System;
using System.Numerics;
using System.Text;

namespace _04.Convert_from_base_10_to_base_N
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int targetBase = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            var sb = new StringBuilder();

            while (number > 0)
            {
                sb.Append(number % targetBase);
                number /= targetBase;
            }

            var result = sb.ToString().ToCharArray();
            Array.Reverse(result);

            Console.WriteLine(result);
        }
    }
}
