using System;
using System.Linq;

namespace _06.Reverse_And_Exclude
{
    class Startup
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var divisor = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % divisor != 0;

            var result = nums.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
