using System;

namespace _10._TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            TopNumber(range);
        }

        private static void TopNumber(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                int sum = 0;
                bool isOdd = false;
                int topNumber = i;
                while (topNumber > 0)
                {
                    int digit = topNumber % 10;
                    if (digit % 2 != 0)
                    {
                        isOdd = true;
                    }
                    sum += digit;

                    topNumber = topNumber / 10;
                }
                topNumber = i;
                // divisible by 8
                if (sum % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(topNumber);
                }

            }
        }
    }
}
