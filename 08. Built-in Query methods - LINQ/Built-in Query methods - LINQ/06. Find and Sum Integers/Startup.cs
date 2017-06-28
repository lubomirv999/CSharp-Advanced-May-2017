using System;
using System.Linq;

namespace _06.Find_and_Sum_Integers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var numbers = input
                .Split(' ')
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new {value, success};
                }).Where(s => s.success)
                .Select(n => n.value)
                .ToList();

            if (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }

            //var input = Console.ReadLine().Split(' ');
            //Stack<int> result = new Stack<int>();

            //foreach (var i in input)
            //{
            //    try
            //    {
            //        var num = int.Parse(i);
            //        result.Push(num);
            //    }
            //    catch (Exception e)
            //    {
            //    }
            //}

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("No match");
            //}
            //else
            //{
            //    Console.WriteLine(result.Sum());
            //}
        }
    }
}
