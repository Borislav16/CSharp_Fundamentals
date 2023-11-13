using System;
using System.Text;

namespace _05._MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ulong number = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine(number * secondNumber);
        }
    }
}
