using System;

namespace _01._GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityHay =double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;
            bool isEnough = true;
            for (int i = 1; i <= 30; i++)
            {
                quantityFood -= 300;
                if (i % 2 == 0)
                {
                    double hayAmount = quantityFood * 0.05;
                    quantityHay -= hayAmount;
                }
                if (i % 3 == 0)
                {
                    double coverAmount = weight / 3;
                    quantityCover -= coverAmount;
                }
                if ((quantityCover <= 0) || (quantityHay <= 0) || (quantityFood <= 0))
                {
                    isEnough = false;
                    break;
                }
                
            }
            
            if(isEnough == true)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood/1000:F2}, Hay: {quantityHay/1000:F2}, Cover: {quantityCover/1000:F2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!"); 
            }
        }
    }
}
