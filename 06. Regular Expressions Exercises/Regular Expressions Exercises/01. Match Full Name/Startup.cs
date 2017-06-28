using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex pattern = new Regex("^[A-Z]{1}[a-z]+? [A-Z]{1}[a-z]+?$");

            while (input != "end")
            {
                var result = pattern.Match(input);

                if (result.Success)
                {
                    Console.WriteLine(result);
                }            

                input = Console.ReadLine();
            }
        }
    }
}
