using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] bombParameters = Console.ReadLine().Split();
            int bomb = int.Parse(bombParameters[0]);
            int bombPower = int.Parse(bombParameters[1]);
            while(numbers.Contains(bomb))
            { 
                int index = numbers.IndexOf(bomb);

                int leftIndex = Math.Max(0, index - bombPower);
                int rightIndex = Math.Min(numbers.Count - 1, index + bombPower);

                int range = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, range);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
