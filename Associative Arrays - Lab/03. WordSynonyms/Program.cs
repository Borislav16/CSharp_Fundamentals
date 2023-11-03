using System;
using System.Collections.Generic;

namespace _03._WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> wordbook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();
                if (!wordbook.ContainsKey(word))
                {
                    wordbook.Add(word, synonyms);
                }
                else
                {
                    wordbook[word] += $", {synonyms}";
                }
            }

            foreach (KeyValuePair<string,string> word in wordbook)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
