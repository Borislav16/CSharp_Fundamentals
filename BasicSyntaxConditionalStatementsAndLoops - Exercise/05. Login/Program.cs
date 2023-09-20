using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string password = "";
            int attemptsCount = 1;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                password += word[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                string attempt = Console.ReadLine();
                if(attempt == password)
                {
                    Console.WriteLine($"User {word} logged in.");
                    break;
                }
                else if (attemptsCount == 4)
                {
                    Console.WriteLine($"User {word} blocked!");
                }
                else if (attempt != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
                attemptsCount++;


            }
        }
    }
}
