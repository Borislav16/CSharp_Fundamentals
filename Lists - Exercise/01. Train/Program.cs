using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitedCommand[0] == "Add")
                {
                    wagons.Add(int.Parse(splitedCommand[1]));
                }
                else
                {
                    int numberOfPassengers = int.Parse(splitedCommand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + numberOfPassengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += numberOfPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
