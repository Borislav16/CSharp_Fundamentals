using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _06._ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = default;
            while ((line = Console.ReadLine()) != "end")
            {
                List<string> splited = line.Split(' ').ToList();
                switch (splited[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(splited[1]);
                        numbers.Add(numberToAdd);
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(splited[1]);
                        numbers.Remove(numberToRemove);
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(splited[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(splited[1]);
                        int indexToInsert = int.Parse(splited[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
