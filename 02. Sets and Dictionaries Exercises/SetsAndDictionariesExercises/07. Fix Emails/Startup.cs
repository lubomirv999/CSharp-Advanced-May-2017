using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_Emails
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input;
            var emails = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "stop")
            {
                var email = Console.ReadLine();

                if (emails.ContainsKey(input))
                {
                    emails[input] = email;
                }
                else
                {
                    emails.Add(input, email);
                }
            }

            foreach (var name in emails.Keys)
            {
                var email = emails[name];
                var domain = email.Substring(email.Length - 2);

                if (domain.ToLower() == "us" || domain.ToLower() == "uk")
                {
                    emails.Remove(name);
                    continue;
                }

                Console.WriteLine($"{name} -> {emails[name]}");
            }
        }
    }
}
