using System;

namespace _11._MathОperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            MathOperations(firstNum, symbol, secondNum);
        }
        static void MathOperations(int firstNum, char symbol, int secondNum)
        {
            switch(symbol)
            {
                case '+':
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case '*':
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case '-':
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case '/':
                    Console.WriteLine(firstNum / secondNum);
                    break;
                default:
                    break;
            }
        }
    }
}
