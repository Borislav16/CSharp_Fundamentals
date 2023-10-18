using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = default;
            while((command = Console.ReadLine()) != "End")
            {
                string[] array = command.Split(' ');
                switch(array[0])
                {
                    case "Add":
                        int addToList = int.Parse(array[1]);
                        numbers.Add(addToList);
                        break;

                    case "Insert":
                        int numToList = int.Parse(array[1]);
                        int indexToList = int.Parse(array[2]);
                        numbers.Insert(indexToList, numToList);
                        break;

                    case "Remove":
                        int removeIndex = int.Parse(array[1]);
                        numbers.RemoveAt(removeIndex);
                        break;
                    case "Shift":
                        if (array[1] == "left")
                        {

                        }
                        else
                        {

                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
