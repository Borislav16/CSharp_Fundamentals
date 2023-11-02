using System;
using System.Collections.Generic;

namespace _02._OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if(!counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase] = 1;
                }
                else
                {
                    counts[wordInLowerCase]++;
                }
            }
            foreach (KeyValuePair<string,int> kvp in counts)
            {
                if(!(kvp.Value % 2 == 0))
                {
                    Console.Write($"{kvp.Key} ");
                }
            
            }
        }
    }
}
