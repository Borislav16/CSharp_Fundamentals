using System;

namespace _04._ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
            
        }
    }
}
