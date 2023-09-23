using System;

namespace _10._LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            char character = char.Parse(Console.ReadLine());
            result = char.IsLower(character);
            if(result == false)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
