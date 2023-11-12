using System;
using System.Text;

namespace _04._CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                sb.Append((char)(symbol + 3));
            }
            Console.WriteLine(sb);
        }
    }
}
