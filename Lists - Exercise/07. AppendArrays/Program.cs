using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> numbers = new List<string>();
            for (int i = text.Count - 1; i >= 0; i--)
            {
                string[] splitedText = text[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                numbers.AddRange(splitedText);

            }
            
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
