using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace _03._MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = default;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splited = command.Split(' ').ToArray();
                if (splited[0] == "Shoot")
                {
                    Shoot(list, splited);
                }
                else if (splited[0] == "Add")
                {
                    Add(list, splited);
                }
                else if (splited[0] == "Strike")
                {
                    Strike(list, splited);
                }
            }
            Console.WriteLine(string.Join("|", list));
        }
        private static void Strike(List<int> list, string[] splited)
        {
            int index = int.Parse(splited[1]);
            int radius = int.Parse(splited[2]);

            int leftIndex = Math.Max(0, index - radius);
            int rightIndex = Math.Min(list.Count - 1, index + radius);
            if ((index >= 0 && index < list.Count) 
                && index + radius >= 0 && index + radius < list.Count
                && index - radius >= 0 && index - radius < list.Count)
            {
                for (int i = 1; i <= radius; i++)
                {
                    list.RemoveAt(index + i);
                }
                list.RemoveAt(index);
                for (int i = 1; i <= radius; i++)
                {
                    list.RemoveAt(index - i);
                }
            }
            // index >= 0 &&  index < list.Count
            // 
            else
            {
                Console.WriteLine("Strike missed!");
                
            }
            
        }

        private static void Add(List<int> list, string[] splited)
        {
            int index = int.Parse(splited[1]);
            int value = int.Parse(splited[2]);
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        private static void Shoot(List<int> list, string[] splited)
        {
            int index = int.Parse(splited[1]);
            int power = int.Parse(splited[2]);
            if (index >= 0 && index < list.Count)
            {
                if (list[index] - power > 0)
                {
                    list[index] = list[index] - power;
                }
                else
                {
                    list.RemoveAt(index);
                }
            }
        }
    }
}
