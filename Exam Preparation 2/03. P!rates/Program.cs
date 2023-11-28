using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> list = new List<City>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arr = input.Split("||");
                string name = arr[0];
                int population = int.Parse(arr[1]);
                int gold = int.Parse(arr[2]);

                City city = list.FirstOrDefault(x =>  x.Name == name);
                if(city is not null)
                {
                    city.Population += population;
                    city.Gold += gold;
                    continue;
                }

                list.Add(new City(name,population,gold));
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitedCommand = command.Split("=>");
                string cityName = splitedCommand[1];

                City city = list.First(x => x.Name == cityName);

                if (splitedCommand[0] == "Plunder")
                {
                    int people = int.Parse(splitedCommand[2]);
                    int gold = int.Parse(splitedCommand[3]);
                    city.Population -= people;
                    city.Gold -= gold;
                    Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {people} citizens killed.");

                    if(city.Population <= 0 || city.Gold <= 0)
                    {
                        Console.WriteLine($"{city.Name} has been wiped off the map!");
                        list.Remove(city);
                    
                    }
                }
                else if (splitedCommand[0] == "Prosper")
                {
                    int gold = int.Parse(splitedCommand[2]);
                    if(gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    city.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");

                }
            }

            if(list.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }
            Console.WriteLine($"Ahoy, Captain! There are {list.Count} wealthy settlements to go to:");
            foreach (City city in list)
            {
                Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
            }
        }
    }
}
