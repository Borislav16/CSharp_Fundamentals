using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace _03._HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string[] arguments = Console.ReadLine().Split(' ');
                string name = arguments[0];
                if (arguments[2] == "going!")
                {
                    if (guestList.Exists(e => e == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (arguments[2] == "not")
                {
                    if(guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    
                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
            
        }

    }

}
