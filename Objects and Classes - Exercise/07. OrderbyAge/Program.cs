using System;
using System.Collections.Generic;
using System.Linq;

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


        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string command = "";
            while((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(' ');
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name,id,age);
                
                int index = GetPerson(list, id);
                if(index != -1)
                {
                    list[index].Name = name;
                    list[index].Age = age;
                    continue;
                }

                list.Add(person);
            }
            list = list.OrderBy(person => person.Age).ToList();

            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }

        public static int GetPerson(List<Person> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
