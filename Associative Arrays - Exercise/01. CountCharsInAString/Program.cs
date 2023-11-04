using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }

                if (!charsCount.ContainsKey(input[i]))
                {
                    charsCount.Add(input[i], 1);
                }
                else
                {
                    charsCount[input[i]]++;
                }
            }

            foreach (KeyValuePair<char,int> kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            
            }
        }
    }
}
