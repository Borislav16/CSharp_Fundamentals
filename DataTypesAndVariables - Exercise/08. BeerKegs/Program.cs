using System;

namespace _08._BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double volume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double formula = Math.PI * (radius * radius) * height;
                if(formula > volume)
                {
                    volume = formula;
                    biggestKeg = model; 
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
