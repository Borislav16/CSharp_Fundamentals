using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<start>\@\#+)(?<barcode>[A-Z]{1}[A-Z|a-z|0-9]{4,}[A-Z]{1})@#+";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                GroupCollection groupCollection = Regex.Match(input, pattern).Groups;
                if(groupCollection.Count == 1)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = groupCollection["barcode"].Value;
                string barcodeDigits = new string(barcode.Where(x => char.IsDigit(x)).ToArray());
                if(barcodeDigits.Length == 0)
                {
                    Console.WriteLine("Product group: 00");    
                }
                else
                {
                    Console.WriteLine($"Product group: {barcodeDigits}");
                }
                
            }
        }
    }
}
