using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            string command = default;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] array = command.Split(' ');
                switch(array[0])
                {
                    case "Delete":
                        int element = int.Parse(array[1]);
                        numbers.Remove(element);
                        break;

                    case "Insert":
                        int newElement = int.Parse(array[1]);
                        int position = int.Parse(array[2]);
                        numbers.Insert(position, newElement);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
