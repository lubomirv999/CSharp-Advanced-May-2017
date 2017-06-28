using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input;
            var resources = new Dictionary<string, long>();

            while ((input = Console.ReadLine()) != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;
                }
                else
                {
                    resources.Add(input, quantity);
                }
            }

            foreach (var resource in resources.Keys)
            {
                Console.WriteLine($"{resource} -> {resources[resource]}");
            }
        }
    }
}
