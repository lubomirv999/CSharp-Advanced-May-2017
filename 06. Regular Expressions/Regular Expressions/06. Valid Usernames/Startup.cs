using System;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex pattern = new Regex(@"^[\w-]{3,16}$");

            while (input != "END")
            {
                var match = pattern.Match(input);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
