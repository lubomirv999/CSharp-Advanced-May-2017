﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Students_by_First_and_Last_Name
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
                    LastName = tokens[1]
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            students = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
