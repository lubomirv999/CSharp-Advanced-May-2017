using System;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = "(^\\+359 2 [0-9]{3} [0-9]{4}$)|(^\\+359-2-[0-9]{3}-[0-9]{4}$)";

            Regex regex = new Regex(pattern);

            while (input.ToUpper() != "END")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
