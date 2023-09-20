using System;

namespace _07._VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            string command = Console.ReadLine();
            while(command != "Start")
            {
                if (command == "0.1"|| command == "0.2" || command =="0.5" || command == "1"|| command =="2")
                {
                    coins += double.Parse(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command != "End")
            {
                if(command == "Nuts")
                {
                    coins -= 2;
                    if(coins >= 0)
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        coins += 2;
                    }
                }
                else if(command == "Water")
                {
                    coins -= 0.7;
                    if (coins >= 0)
                    {
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        coins += 0.7;
                    }
                }
                else if (command == "Crisps")
                {
                    coins -= 1.5;
                    if (coins >= 0)
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        coins += 1.5;
                    }
                }
                else if (command == "Soda")
                {
                    coins -= 0.8;
                    if (coins >= 0)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        coins += 0.8;
                    }
                }
                else if (command == "Coke")
                {
                    coins -= 1;
                    if (coins >= 0)
                    {
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        coins += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coins:F2}");
        }
    }
}
