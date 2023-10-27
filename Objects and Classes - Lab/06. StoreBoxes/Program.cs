using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] data = line.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = itemName;
                box.quantity = itemQuantity;
                box.PriceBox = itemPrice;
                box.TotalPrice = itemQuantity * itemPrice;

                boxes.Add(box);

                line = Console.ReadLine();
                
            }
            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();


            foreach (Box a in sortedBox)
            {
                Console.WriteLine($"{a.SerialNumber}");
                Console.WriteLine($"-- {a.Item} - ${a.PriceBox:f2}: {a.quantity}");
                Console.WriteLine($"-- ${a.TotalPrice:f2}");
            }
        }
    }

    
    public class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int quantity { get; set; }
        public decimal PriceBox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
