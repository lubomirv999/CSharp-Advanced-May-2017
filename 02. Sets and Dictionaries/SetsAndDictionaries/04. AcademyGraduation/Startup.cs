using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AcademyGraduation
{
    class Startup
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var student = Console.ReadLine();
                var result = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(r => double.Parse(r, CultureInfo.InvariantCulture))
                    .ToList();

                students.Add(student, result);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
