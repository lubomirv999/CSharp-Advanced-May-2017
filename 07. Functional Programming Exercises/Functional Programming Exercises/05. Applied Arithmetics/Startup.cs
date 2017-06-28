using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Startup
    {
        static void Main(string[] args)
        {
            Func<int, string, int> convert = (i, s) =>
            {
                switch (s)
                {
                    case "add":
                        return i + 1;
                    case "multiply":
                        return i * 2;
                    case "subtract":
                        return i - 1;
                }

                return i;
            };

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", nums).Trim());
                }
                else
                {
                    nums = nums.Select(i => convert(i, command)).ToList();
                }

                command = Console.ReadLine();
            }
        }
    }
}