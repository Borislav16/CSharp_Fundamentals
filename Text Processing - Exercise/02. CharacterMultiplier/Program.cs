using System;

namespace _02._CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" "); 
            string str1 = array[0];
            string str2 = array[1];
            int sum = 0;
            if(str1.Length >= str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (i >= str2.Length)
                    {
                        sum += str1[i];
                    }
                    else
                    {
                        int multiplication = str1[i] * str2[i];
                        sum += multiplication;
                    }
                }
            }
            else
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (i >= str1.Length)
                    {
                        sum += str2[i];
                    }
                    else
                    {
                        int multiplication = str1[i] * str2[i];
                        sum += multiplication;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
