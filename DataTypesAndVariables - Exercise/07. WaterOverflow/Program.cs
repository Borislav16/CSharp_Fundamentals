using System;

namespace _07._WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int quantities = 0;
            for (int i = 0; i < n; i++)
            {
                int newQuantitie = int.Parse(Console.ReadLine());
                if ( newQuantitie + quantities > capacity )
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else
                {
                    quantities += newQuantitie;
                }
            }
            Console.WriteLine($"{quantities}");


        }
    }
}
