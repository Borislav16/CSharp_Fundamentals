using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._NetherRealms
{
    class Demon
    {
        public Demon(string name, int health, decimal damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public decimal Damage { get; set; }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();
            string input = Console.ReadLine();
            string[] demonPatterns = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            

            foreach (string demonName in demonPatterns)
            {
                int health = CalculateHealth(demonName);
                decimal damage = CalculateDamage(demonName);
                Demon demon = new Demon(demonName,health,damage);

                demons.Add(demon);
            }
            List<Demon> sortedDemons = demons.OrderBy(x => x.Name).ToList();

            sortedDemons.ForEach(x => Console.WriteLine($"{x.Name} - {x.Health} health, {x.Damage:F2} damage"));

        }
            

    

        private static decimal CalculateDamage(string demonString)
        {
            decimal damage = 0;
            string numberPatttern = @"((?:[-+]*)(?:\d+\.\d+|\d+))";
            string multiplyPattern = @"[\*\/]";
            MatchCollection matches = Regex.Matches(demonString, numberPatttern);

            foreach (Match match in matches)
            {
                decimal number;
                decimal.TryParse(match.Value, out number);
                damage += number;
            }

            matches = Regex.Matches(demonString, multiplyPattern);
            foreach (Match match in matches)
            {
                switch (match.Value)
                {
                    case "/":
                        damage /= 2;
                        break;
                    case "*":
                        damage *= 2;
                        break;
                }
            }

            return damage;
        }

        private static int CalculateHealth(string demonString)
        {
            int health = 0;
            string wordPattern = @"(?<health>[^0-9\.\*\/\-\+])";
            MatchCollection matches = Regex.Matches(demonString, wordPattern);

            foreach (Match match in matches)
            {
                health += match.Value[0];
            }

            return health;
        }
    }
}
