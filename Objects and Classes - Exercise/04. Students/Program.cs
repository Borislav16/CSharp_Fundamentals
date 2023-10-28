using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04._Students
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] currentStudent = Console.ReadLine().Split();
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                float grade = float.Parse(currentStudent[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }
            List<Student> orderedList = students.OrderByDescending(e => e.Grade).ToList();
            

            Console.WriteLine(string.Join("\n", orderedList));
        }
    }
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public float Grade { get; set; }
        
        public Student()
        { 
        
        }
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }

    }
}
