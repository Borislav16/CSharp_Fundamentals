using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;

        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            if(Type == "truck")
            {
                Type = "Truck";
            }
            else
            {
                Type = "Car";
            }
            return $"Type: {Type}\n"+
                   $"Model: {Model}\n"+
                   $"Color: {Color}\n"+
                   $"Horsepower: {Horsepower}\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> list = new List<Catalogue>();
            string command = string.Empty;
            double averageTruckHorsepower = 0;
            int countOfTruck = 0;
            double averageCarHorsepower = 0;
            int countOfCar = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicles = command.Split(" ");
                string type = vehicles[0];
                string model = vehicles[1];
                string color = vehicles[2];
                double horsepower = double.Parse(vehicles[3]);

                Catalogue catalogue = new Catalogue(type, model, color, horsepower);

                if(type == "truck")
                {
                    averageTruckHorsepower += horsepower;
                    countOfTruck++;
                }
                else
                {
                    averageCarHorsepower += horsepower;
                    countOfCar++;
                }
                list.Add(catalogue);
                
            }
            averageTruckHorsepower = averageTruckHorsepower / countOfTruck;
            averageCarHorsepower = averageCarHorsepower / countOfCar;
            while((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Catalogue mod in list)
                {
                    if(mod.Model == command)
                    {
                        Console.WriteLine(mod.ToString());
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:F2}.");

            
        }
    }
}
