using System;
using System.Linq;

namespace _02._TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int emptySpots = 0;
            for (int i = 0; i < lift.Length; i++)
            {
                int wagons = lift[i];
                if(peopleCount - (Math.Abs(wagons - 4)) >= 0) 
                {
                    peopleCount = peopleCount - (Math.Abs(wagons - 4));
                    lift[i] = lift[i] + Math.Abs(wagons - 4);
                }
                else
                {
                    emptySpots = 4 - peopleCount;
                    peopleCount = 0;
                    lift[i] = lift[i] + (4 - emptySpots);
                }
            }
            if(peopleCount > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if(emptySpots != 0)
            {
                Console.WriteLine("The lift has empty spots!"); 
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            
        }
    }
}
