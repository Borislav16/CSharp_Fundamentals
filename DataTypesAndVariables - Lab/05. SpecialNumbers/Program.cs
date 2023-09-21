using System;

namespace _05._SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                bool special = false;
                int number = i;
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }
                
                if (sum == 5 || sum  == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
