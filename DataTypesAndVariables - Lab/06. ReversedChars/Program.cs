using System;

namespace _06._ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            for (int i = 1; i <= 3; i++)
            {
                string symbol = Console.ReadLine();
                text += symbol; 
            }
            for (int i = text.Length - 1; i >= 0; i--)
            {
                char symbol = text[i];
                Console.Write(symbol + " ");
            }
            

        }
    }
}
