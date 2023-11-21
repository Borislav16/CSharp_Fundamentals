using System;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Bar
    {
        public Bar(string name, string product, int count, decimal price)
        {
            Name = name;
            Product = product;
            Count = count;
            Price = price;
        }
        public string Name { get; set; }

        public string Product { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        

        public decimal TotalPrice()
        {
            return Count * Price;
        }

        public override string ToString()
        {
            return $"{Name}: {Product} - {TotalPrice():F2}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalIncome = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$.%]*\<(?<product>\w+)\>[^|$.%]*\|(?<count>\d+)\|[^|$.%]*?(?<price>\d+(?:\.\d+)?)\$";
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    Bar bar = new Bar(name, product, count, price);

                    Console.WriteLine(bar);

                    totalIncome += bar.TotalPrice();
                }

            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
