using System;

namespace _08._MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            RaiseToPower(number, power);
        }
        static void RaiseToPower(double number , double power )
        {
            Console.WriteLine(Math.Pow(number, power));
        }
    }
}
