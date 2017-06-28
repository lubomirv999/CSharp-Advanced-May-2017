using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    class Startup
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var uniquePeople = new HashSet<string>();

            for (int i = 0; i < input; i++)
            {
                var people = Console.ReadLine();
                uniquePeople.Add(people);
            }

            foreach (var person in uniquePeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
