using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int,int> numberOccurences = new SortedDictionary<int,int>();
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            foreach (int number in numbers)
            {
                if(!numberOccurences.ContainsKey(number))
                {
                    numberOccurences.Add(number, 1);
                
                }
                else
                {
                    numberOccurences[number]++;
                }
            }

            
            foreach (KeyValuePair<int,int> kvp in numberOccurences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            } 
            
        }
    }
}
