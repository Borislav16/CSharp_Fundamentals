using System;

namespace _08._FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double result = FactorialDivision(number1, number2);
            Console.WriteLine($"{result:F2}");
        }

        private static double FactorialDivision(int number1, int number2)
        {
            double fact1 = 1;
            for (int i = 1; i <= number1; i++)
            {
                fact1 *= i;
            }
            double fact2 = 1;
            for (int i = 1; i <= number2; i++)
            {
                fact2 *= i;
            }
            return fact1 / fact2;
        }
    }
}
