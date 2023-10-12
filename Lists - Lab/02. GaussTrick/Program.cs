using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - i - 1]);
                
            }
            if(numbers.Count % 2 == 1)
            {
                int middleIndex = numbers.Count / 2;
                result.Add(numbers[middleIndex]);

            }
            Console.WriteLine(string.Join((" "), result)); 
        }
    }
}
