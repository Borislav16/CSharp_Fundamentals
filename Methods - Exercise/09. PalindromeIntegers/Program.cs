using System;

namespace _09._PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            char[] array = command.ToCharArray();

            while (command != "END")
            {
                bool isTrue = Palindrome(array);
                if(isTrue)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                command = Console.ReadLine();
                array = command.ToCharArray();
            }
        }

        private static bool Palindrome(char[] array)
        {
            char[] reversed = new char[array.Length];
            int count = 0;
            bool istrue = false;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversed[count] = array[i];
                count++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == reversed[i])
                {
                    istrue = true;
                }
                else
                {
                    return false;
                }
            }
            return istrue;
        }
    }
}
