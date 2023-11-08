using System;
using System.Collections.Generic;

namespace _01._ReverseStrings
{
    class Reverse
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            string reversed = "";
            while ((word = Console.ReadLine()) != "end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                Console.WriteLine($"{word} = {reversed}");
                reversed = "";
            
            }
        }
    }
}
