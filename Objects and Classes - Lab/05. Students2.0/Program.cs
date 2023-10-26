using System;
using System.Collections.Generic;

namespace _05._Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = default;
            List<Student> students = new List<Student>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentStudent = command.Split(' ');
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                int age = int.Parse(currentStudent[2]);
                string homeTown = currentStudent[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                int index = Exist(firstName, lastName, students);
                if (index != -1)
                {
                    students[index].Age = age;
                    students[index].HomeTown = homeTown;
                    continue;
                }
                students.Add(student);
            }
            string givenHomeTown = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == givenHomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static int Exist(string firstName, string lastName, List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == firstName && students[i].LastName == lastName)
                {
                    return i;
                }
            }
            return -1;
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
