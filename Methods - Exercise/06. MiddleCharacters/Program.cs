using System;

namespace _06._MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            MiddleChar(array);
        }

        static void MiddleChar(char[] array)
        {
            if (array.Length % 2 == 0)
            {
                Console.Write(array[array.Length / 2 - 1]);
                Console.Write(array[array.Length / 2]);
            }
            else
            {
                Console.Write(array[(array.Length / 2)]);
            }
        }
    }
}
