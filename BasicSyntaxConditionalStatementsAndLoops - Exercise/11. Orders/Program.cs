using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= count; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double orderPrice = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
