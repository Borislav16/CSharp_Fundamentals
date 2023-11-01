using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue(string type, string model, string color, decimal horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;

        }

        private string type = ""; 

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = Capitalize(value);
            }
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }

        public string Capitalize(string value)
        {
            char[] charArray = value.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]); 
            }
            return new string(charArray);
        }

        public override string ToString()
        {
            
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {Horsepower}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> list = new List<Catalogue>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicles = command.Split(" ");
                string type = vehicles[0];
                string model = vehicles[1];
                string color = vehicles[2];
                decimal horsepower = decimal.Parse(vehicles[3]);

                Catalogue catalogue = new Catalogue(type, model, color, horsepower);
                list.Add(catalogue);

            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Catalogue mod in list)
                {
                    if (mod.Model == command)
                    {
                        Console.WriteLine(mod.ToString());
                    }
                }
            }
            decimal averageHP = list.
                Where(catalogue => catalogue.Type == "Car")
                .Select(catalogue => catalogue.Horsepower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = list.
                Where(catalogue => catalogue.Type == "Truck")
                .Select(catalogue => catalogue.Horsepower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");



        }
    }
}
