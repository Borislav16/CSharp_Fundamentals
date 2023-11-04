using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class ProductsPrice
    {
        public ProductsPrice(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public void ChangePrice(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;

        }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ProductsPrice> orders = new Dictionary<string, ProductsPrice>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] array = input.Split();
                string name = array[0];
                decimal price = decimal.Parse(array[1]);
                int quantity = int.Parse(array[2]);
                ProductsPrice productsPrice = new ProductsPrice(name, price, quantity);
                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, productsPrice);
                }
                else
                {
                    orders[name].ChangePrice(price, quantity);
                }
            }

            foreach (KeyValuePair<string, ProductsPrice> kvp in orders)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
