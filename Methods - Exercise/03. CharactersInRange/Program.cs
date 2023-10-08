using System;

namespace _03._CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintChars(first, second);
        }
        static void PrintChars(char first, char second)
        {
            if (first > second)
            {
                char temp = first;
                first = second;
                second = temp;
            }

            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
