using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = default;
            List<Student> students = new List<Student>();
            while((command = Console.ReadLine()) != "end")
            {
                string[] currentStudent = command.Split(' ');
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                int age = int.Parse(currentStudent[2]);
                string homeTown = currentStudent[3];

                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
            }
            string givenHomeTown = Console.ReadLine();
            foreach (Student student in students)
            {
                if(student.HomeTown == givenHomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public Student()
        {
        
        }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
}
