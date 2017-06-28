using System;
using System.Linq;

namespace _01.Students_Results
{
    class Startup
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|",
                "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            for (int i = 0; i < numberOfPeople; i++)
            {
                var inputRow = Console.ReadLine();
                var person = inputRow.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var name = person[0];
                double[] grades = person[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                var average = grades.Average();

                Console.WriteLine(string.Format(
                    "{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    name, grades[0], grades[1], grades[2], average));
            }
        }
    }
}
