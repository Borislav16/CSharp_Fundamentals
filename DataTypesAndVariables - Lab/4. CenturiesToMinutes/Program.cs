using System;

namespace _4._CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {hours * 60} minutes");
        }
    }
}
