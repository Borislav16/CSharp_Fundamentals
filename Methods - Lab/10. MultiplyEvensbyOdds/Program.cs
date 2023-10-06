using System;
using System.Linq;

namespace _10._MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            

            GetMultipleOfEvenAndOdds(number);
        }

        static void GetMultipleOfEvenAndOdds(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;
            while(number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
                number = number / 10;
            }
            int multiple = sumEven * sumOdd;
            Console.WriteLine(multiple);
        }
    }
}
