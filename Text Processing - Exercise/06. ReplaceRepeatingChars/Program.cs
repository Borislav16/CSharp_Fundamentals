using System;
using System.Text;

namespace _06._ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    stringBuilder.Append(input[i]);
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
