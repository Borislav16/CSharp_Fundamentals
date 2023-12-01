using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06._HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public string Name { get; set; }

        public int HP { get; set; }

        public int MP { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"  HP: {HP}\n" +
                   $"  MP: {MP}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                

                heroes.Add(new Hero(name, hp, mp));
            }
            string command = string.Empty;
            while((command = Console.ReadLine()) != "End")
            {
                string[] splitedCommand = command.Split(" - ").ToArray();
                string commandName = splitedCommand[0];
                if (commandName == "CastSpell")
                {
                    string heroName = splitedCommand[1];
                    Hero foundHero = heroes.First(h => h.Name == heroName);
                    if (foundHero is not null)
                    {
                        int mp = int.Parse(splitedCommand[2]);
                        string spellName = splitedCommand[3];
                        if (mp > foundHero.MP)
                        {
                            Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!");
                            continue;
                        }
                        foundHero.MP -= mp;
                        Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
                    }

                }
                else if (commandName == "TakeDamage")
                {
                    string heroName = splitedCommand[1];
                    Hero foundHero = heroes.First(h => h.Name == heroName);
                    if (foundHero is not null)
                    {
                        int damage = int.Parse(splitedCommand[2]);
                        string attacker = splitedCommand[3];
                        if (foundHero.HP - damage > 0)
                        {
                            foundHero.HP -= damage;
                            Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
                            continue;
                        }
                        Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
                        heroes.Remove(foundHero);

                    }
                }
                else if (commandName == "Recharge")
                {
                    string heroName = splitedCommand[1];
                    Hero foundHero = heroes.First(h => h.Name == heroName);
                    if (foundHero is not null)
                    {
                        int mp = int.Parse(splitedCommand[2]);
                        int diff = 200 - foundHero.MP;
                        if (foundHero.MP + mp >= 200)
                        {
                            foundHero.MP = 200;
                            Console.WriteLine($"{foundHero.Name} recharged for {diff} MP!");
                            continue;
                        }
                        foundHero.MP += mp;
                        Console.WriteLine($"{foundHero.Name} recharged for {mp} MP!");

                    }
                }
                else if (commandName == "Heal")
                {
                    string heroName = splitedCommand[1];
                    Hero foundHero = heroes.First(h => h.Name == heroName);
                    if (foundHero is not null)
                    {
                        int hp = int.Parse(splitedCommand[2]);
                        int diff = 100 - foundHero.HP;
                        if (foundHero.HP + hp >= 100)
                        {
                            foundHero.HP = 100;
                            Console.WriteLine($"{foundHero.Name} healed for {diff} HP!");
                            continue;
                        }
                        foundHero.HP += hp;
                        Console.WriteLine($"{foundHero.Name} healed for {hp} HP!");
                    }
                }
            }

            foreach (Hero hero in heroes)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
