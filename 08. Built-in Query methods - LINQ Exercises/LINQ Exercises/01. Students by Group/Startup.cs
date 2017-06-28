using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Students_by_Group
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split();

                var student = new Student
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Group = int.Parse(tokens[2])
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            var result = students.Where(s => s.Group == 2).OrderBy(s => s.FirstName).ToList();

            result.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Group { get; set; }
    }
}
