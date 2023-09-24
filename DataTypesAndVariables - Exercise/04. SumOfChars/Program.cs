using System;

namespace _04._SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < nLines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
