using System;

namespace _05._AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int add = Add(number1, number2);
            int subtract = Subtract(add, number3);
            Console.WriteLine(subtract);
        }

        static int Subtract(int add, int number3)
        {
            return add - number3;
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
