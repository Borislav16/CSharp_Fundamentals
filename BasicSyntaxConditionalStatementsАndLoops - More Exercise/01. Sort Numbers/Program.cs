using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                int number =int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
