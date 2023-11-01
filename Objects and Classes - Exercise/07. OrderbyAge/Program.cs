using System;
using System.Collections.Generic;

namespace _07._OrderbyAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string command = "";
            while((command = Console.ReadLine()) != "End")
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name,id,age);

                list.Add(person);
            }
        }
    }
}
