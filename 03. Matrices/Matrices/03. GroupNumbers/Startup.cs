using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GroupNumbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var zero = numbers.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var one = numbers.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var two = numbers.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
        }
    }
}
