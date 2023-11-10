using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _05._DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            List<char> letters = new List<char>();
            List<char> symbols = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                bool isTrue = char.IsDigit(array[i]);
                bool isFalse = char.IsLetter(array[i]);
                if(isTrue)
                {
                    Console.Write(array[i]);
                }
                else if(isFalse)
                {
                    letters.Add(array[i]);
                }
                else
                {
                    symbols.Add(array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", symbols));
        }
    }
}
