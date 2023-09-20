using System;

namespace _09._PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfTheLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            int freeBelts = countOfStudents / 6;
            // calculation
            double totalLightsabers = priceOfTheLightsabers * (Math.Ceiling(countOfStudents + (countOfStudents * 0.1)));
            double totalRobers = priceOfRobes * countOfStudents;
            double totalBelts = priceOfBelts * (countOfStudents - freeBelts);
            double neededEquipment = totalLightsabers + totalRobers + totalBelts;
            // output   
            if(amountOfMoney >= neededEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {neededEquipment:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(neededEquipment - amountOfMoney):F2}lv more.");
            }
        }
    }
}
