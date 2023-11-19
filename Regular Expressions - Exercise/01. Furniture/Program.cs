using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Furniture
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            string input = string.Empty;
            string pattern = @">>([A-Z]\w+)<<(\d+\.\d+|\d+)(\!)(\d+)";
            Regex r = new Regex(pattern);
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups[1].Value;
                    furniture.Price = decimal.Parse(match.Groups[2].Value);
                    furniture.Quantity = int.Parse(match.Groups[4].Value);

                    furnitures.Add(furniture);
                }

            }
            decimal totalCost = 0;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalCost += furniture.Total();
            }

            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}
