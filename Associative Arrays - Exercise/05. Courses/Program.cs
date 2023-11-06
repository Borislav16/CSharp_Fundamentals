using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _05._Courses
{
    class Courses
    {
        public Courses(string courseName, string student)
        {
            CourseName = courseName;
            Student = student;
            Students = new List<string>{student};
        }
        public string CourseName { get; set; }

        public string Student { get; set; }

        public List<string> Students { get; set; }

        public override string ToString()
        {
            string allStudents = string.Empty;
            for (int i = 0; i < Students.Count - 1; i++)
            {
                allStudents += $"-- {Students[i]}\n";
            }
            allStudents += $"-- {Students[Students.Count - 1]}";
            return $"{CourseName}: {Students.Count}\n" +
                   $"{allStudents}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Courses> peopleInCourses = new Dictionary<string,Courses>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] newStudent = command.Split(" : ");
                string courseName = newStudent[0];
                string student = newStudent[1];
                Courses courses = new Courses(courseName, student);
                if(!peopleInCourses.ContainsKey(courseName))
                {
                    peopleInCourses.Add(courseName, courses);
                }
                else
                {
                    peopleInCourses[courseName].Students.Add(student);
                }
            }

            foreach (KeyValuePair<string,Courses> kvp in peopleInCourses)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
