using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = default;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] array = command.Split();
                string action = array[0];
                if (action == "Add")
                {
                    int task = int.Parse(array[1]);
                    numbers.Add(task);
                }
                else if (action == "Insert")
                {
                    int task = int.Parse(array[1]);
                    int index = int.Parse(array[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string direction = array[1];
                    if (direction == "left")
                    {
                        int task = int.Parse(array[2]);
                        while (task != 0)
                        {
                            int currentnumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(currentnumber);
                            task--;
                        }
                    }
                    else if (direction == "right")
                    {
                        int task = int.Parse(array[2]);
                        while (task != 0)
                        {
                            int currentnumber = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, currentnumber);
                            task--;
                        }
                    }
                }
                else if (action == "Remove")
                {
                    int task = int.Parse(array[1]);
                    if (task >= 0 && task < numbers.Count)
                    {
                        numbers.RemoveAt(task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
