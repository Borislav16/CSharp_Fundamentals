using System;
using System.Collections.Generic;

namespace _02._AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourses = new Dictionary<string, uint>();

            string input;
            while((input = Console.ReadLine()) != "stop")
            {
                
                if(!resourses.ContainsKey(input))
                {
                    resourses.Add(input, 0);
                
                }
                uint quantity = uint.Parse(Console.ReadLine());
                resourses[input] += quantity;
                
            
            }
            foreach (KeyValuePair<string, uint> kvp in resourses)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
