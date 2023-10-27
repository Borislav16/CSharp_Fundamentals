using System;

namespace _06._StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = default;
            while ((command = Console.ReadLine()) != "end")
            {
                
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public Box(string serialNumber, Item item, decimal quantity)
        {
            SerialNumber = serialNumber;
            item.Name = item.Name;
            item.Price = item.Price;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public decimal Quantity { get; set; }

        public decimal BoxPrice
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }
}
