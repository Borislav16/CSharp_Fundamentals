using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            Random random = new Random();
            for (int i = 0; i < text.Count - 1; i++)
            {
                int randomIndex = random.Next(text.Count);

                string currentWord = text[i];
                string randomWord = text[randomIndex];

                text[i] = randomWord;
                text[randomIndex] = currentWord;

            }

            foreach (string word in text)
            {
                Console.WriteLine(word);
            }

        }
    }
}
