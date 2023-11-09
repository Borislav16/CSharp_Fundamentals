using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string input = Console.ReadLine();

            while(input.Contains(filter))
            {
                int startIndex = input.IndexOf(filter);
                input = input.Remove(startIndex,filter.Length);
            }
            Console.WriteLine(input);
        }
    }
}
