using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Parse_URLs
{
    class Startup
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();
            var pattern = "://";

            var tokens = url.Split(new[] {pattern}, StringSplitOptions.RemoveEmptyEntries);           

            if (tokens.Length !=2 || tokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var protocol = tokens[0];
                var indexResource = tokens[1].IndexOf('/');

                var server = tokens[1].Substring(0, indexResource);
                var resources = tokens[1].Substring(indexResource + 1);

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
