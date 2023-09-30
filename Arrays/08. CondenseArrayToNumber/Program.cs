using System;
using System.Linq;

namespace _08._CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = array.Length;
            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    array[i] = array[i] + array[i + 1];
                    
                }

                Console.WriteLine();
                count--;
            }
            Console.WriteLine(array[0]);
        }
    }
}
