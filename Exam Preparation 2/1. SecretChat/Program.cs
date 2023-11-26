using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1._SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;
            while((command = Console.ReadLine()) != "Reveal")
            {
                string[] splitedCommand = command.Split(":|:");
                if (splitedCommand[0] == "InsertSpace")
                {
                    
                    int givenIndex = int.Parse(splitedCommand[1]);
                    input = input.Insert(givenIndex, " ");
                }
                else if (splitedCommand[0] == "ChangeAll")
                {
                    string substring = splitedCommand[1];
                    string replacement = splitedCommand[2];
                    input = input.Replace(substring, replacement);
                }
                else if (splitedCommand[0] == "Reverse")
                {
                    string substring = splitedCommand[1];
                    int substringIndex = input.IndexOf(substring);
                    if(substringIndex < 0)
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    input = input.Remove(substringIndex, substring.Length);
                    string reversedSubstring = new string(substring.Reverse().ToArray());
                    input += reversedSubstring;
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
