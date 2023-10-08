using System;

namespace _02._VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            VowelsCOunt(array);
        }
        static void VowelsCOunt(char[] array)
        {
            int vowels = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'a' || array[i] == 'u' || array[i] == 'o' || array[i] == 'i' || array[i] == 'e'
                    || array[i] == 'A' || array[i] == 'U' || array[i] == 'O' || array[i] == 'I' || array[i] == 'E')
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels);
        }
    }
}
