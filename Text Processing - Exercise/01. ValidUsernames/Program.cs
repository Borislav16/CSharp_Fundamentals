using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] usernames = Console.ReadLine().Split(", ");
            for (int i = 0; i < usernames.Length; i++)
            {

                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    if (IsValidUsername(usernames[i]))
                    {
                        Console.WriteLine(usernames[i]);
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        private static bool IsValidUsername(string usernames)
        {
            return usernames.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_');
        }
    }
}
