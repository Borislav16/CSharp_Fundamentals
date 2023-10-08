using System;

namespace _04._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] password = text.ToCharArray();
            PassValidator(password);

        }
        static void PassValidator(char[] password)
        {
            int digitCount = 0;
            int charCount = 0;
            int other = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122))
                {
                    charCount++;
                }
                else if(password[i] >= 48 && password[i] <= 57)
                {
                    digitCount++;
                }
                else
                {
                    other++;
                }
            }
            if(digitCount >= 2 && (charCount >= 6 && charCount <= 10))
            {
                Console.WriteLine("Password is valid");
            }
            if(other > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                if (digitCount < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    return;
                }
            }
            if (!(charCount >= 6 && charCount <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            
        }
    }
}
