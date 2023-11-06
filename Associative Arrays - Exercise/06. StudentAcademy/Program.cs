using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _06._StudentAcademy
{
    class Student
    {
        public Student(string name, decimal grade)
        {
            Name = name;
            Grade = grade;
            GradesList = new List<decimal> { Grade };
        }
        public string Name { get; set; }

        public decimal Grade { get; set; }

        public List<decimal> GradesList { get; set; }

        public override string ToString()
        {
            decimal averageGrade = 0;

            for (int i = 0; i < GradesList.Count; i++)
            {
                averageGrade += GradesList[i];
            }
            averageGrade /= GradesList.Count;
            if( averageGrade >= 4.5m )
            {
                return $"{Name} -> {averageGrade:F2}";
            }
            return null;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentSuccess = new Dictionary<string, Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                Student student = new Student(name, grade);
                if (!studentSuccess.ContainsKey(name))
                {
                    studentSuccess.Add(name, student);
                }
                else
                {
                    studentSuccess[name].GradesList.Add(grade);
                }
            }

            foreach (KeyValuePair<string, Student> kvp in studentSuccess)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
