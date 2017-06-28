using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.Valid_Usernames
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(username => Regex.IsMatch(username, "^[a-zA-Z][a-zA-Z0-9_]{2,24}$"))
                .ToArray();

            int maxLength = int.MinValue;
            string firstResultName = string.Empty;
            string secondResultName = string.Empty;

            for (int i = 0; i < usernames.Length - 1; i++)
            {
                string firstName = usernames[i];
                string secondName = usernames[i + 1];

                int currentLength = firstName.Length + secondName.Length;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    firstResultName = firstName;
                    secondResultName = secondName;
                }
            }

            Console.WriteLine(firstResultName);
            Console.WriteLine(secondResultName);
        }
    }
}
