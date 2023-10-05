using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Calculation(command, firstNum, secondNum);

        }
        static void Calculation(string command, int firstNum, int secondNum)
        {
            switch(command)
            {
                case "add":
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case "subtract":
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case "multiply":
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case "divide":
                    Console.WriteLine(firstNum / secondNum);
                    break;
            }
        }
    }
}
