using System;
using System.Drawing;

namespace _03._GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spent = balance;
            string command = Console.ReadLine();
            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {

                    if (balance > 39.99)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        balance -= 39.99;
                    }
                    else if (balance == 39.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 39.99;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "CS: OG")
                {

                    if (balance > 15.99)
                    {
                        Console.WriteLine("Bought CS: OG");
                        balance -= 15.99;
                    }
                    else if (balance == 15.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 15.99;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {

                    if (balance > 19.99)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        balance -= 19.99;
                    }
                    else if (balance == 19.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 19.99;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {

                    if (balance > 59.99)
                    {
                        Console.WriteLine("Bought Honored 2");
                        balance -= 59.99;
                    }
                    else if (balance == 59.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 59.99;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {

                    if (balance > 29.99)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        balance -= 29.99;
                    }
                    else if (balance == 29.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 29.99;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {

                    if (balance > 39.99)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        balance -= 39.99;
                    }
                    else if (balance == 39.99)
                    {
                        Console.WriteLine("Out of money!");
                        balance -= 39.99;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                command = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${spent - balance:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
