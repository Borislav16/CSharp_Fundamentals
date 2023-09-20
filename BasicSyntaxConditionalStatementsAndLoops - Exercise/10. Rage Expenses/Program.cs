using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            // calculation
            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = trashedKeyboard / 2;
            double totalPrice = trashedHeadset * headsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");

            
        }
    }
}
