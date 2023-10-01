using System;

namespace _03._ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArray = numbers.Split(' ');
                if(i == 0)
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                else if(i % 2 != 0)
                {
                    firstArr[i] = numbersArray[1];
                    secondArr[i] = numbersArray[0];
                }
                else
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{firstArr[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{secondArr[i]} ");
            }


        }
    }
}
