using System;
using System.Collections.Generic;

namespace _04._SoftUniParking
{
    class User
    {
        public User(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }
        public string UserName { get; set; }

        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,User> users = new Dictionary<string,User>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string arguments = Console.ReadLine();
                string[] splitedArg = arguments.Split();
                string command = splitedArg[0];
                string userName = splitedArg[1];
                
                switch(command)
                {
                    case "register":
                        string licensePlate = splitedArg[2];
                        User user = new User(userName, licensePlate);
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, user);
                            Console.WriteLine($"{userName} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;

                    case "unregister":
                        if(users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string,User> kvp in users)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
