using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());
            while(evenNumber % 2 != 0)
            {
                
                Console.WriteLine("Please write an even number.");
                evenNumber = int.Parse(Console.ReadLine());
            }
            if (evenNumber < 0)
            {
                Console.WriteLine($"The number is: {evenNumber * -1}");
            }
            else
            {
                Console.WriteLine($"The number is: {evenNumber}");
            }
        }
    }
}
