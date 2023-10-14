using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int countOfChanges = 0;
            string line = default;
            while ((line = Console.ReadLine()) != "end")
            {
                List<string> splited = line.Split(' ').ToList();
                switch (splited[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(splited[1]);
                        numbers.Add(numberToAdd);
                        countOfChanges++;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(splited[1]);
                        numbers.Remove(numberToRemove);
                        countOfChanges++;
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(splited[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        countOfChanges++;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(splited[1]);
                        int indexToInsert = int.Parse(splited[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        countOfChanges++;
                        break;

                    case "Contains":
                        int numberToContains = int.Parse(splited[1]);
                        bool isTrue = numbers.Contains(numberToContains);
                        if(isTrue == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        switch (splited[1])
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int splitedNumber = int.Parse(splited[2]);
                                    if (numbers[i] < splitedNumber)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int splitedNumber = int.Parse(splited[2]);
                                    if (numbers[i] > splitedNumber)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int splitedNumber = int.Parse(splited[2]);
                                    if (numbers[i] <= splitedNumber)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int splitedNumber = int.Parse(splited[2]);
                                    if (numbers[i] >= splitedNumber)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                        }

                        break;
                }
            }
            if(countOfChanges > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
