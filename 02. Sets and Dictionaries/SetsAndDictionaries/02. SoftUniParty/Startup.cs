using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniParty
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var guests = new SortedSet<string>();

            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest); 
            }
        }
    }
}
