using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Startup
    {
        static void Main(string[] args)
        {           
            string input;
            var phonebook = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "search")
            {
                var tokens = input.Split('-');
                var name = tokens[0];
                var number = tokens[1];

                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }
            }

            while ((input = Console.ReadLine()) != "stop")
            {
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }
        }
    }
}
