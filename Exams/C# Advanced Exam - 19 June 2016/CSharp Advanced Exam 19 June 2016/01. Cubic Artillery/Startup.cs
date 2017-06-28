using System;
using System.Collections.Generic;

namespace _01.Cubic_Artillery
{
    class Startup
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();

            var currentCapacity = maxCapacity;

            string input;

            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = input.Split(' ');

                foreach (var element in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(element, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;

                        while (bunkers.Count > 1)
                        {
                            if (currentCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                            }

                            weapons.Clear();
                            currentCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (currentCapacity < weapon)
                                    currentCapacity += weapons.Dequeue();

                                weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                            }
                        }
                    }
                }
            }
        }
    }
}