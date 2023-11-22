using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._StarEnigma
{
    class Message
    {
        public Message(string planetName, uint population, string attackType, uint soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }

        public string PlanetName { get; set; }

        public uint Population { get; set; }

        public string AttackType { get; set; }

        public uint SoldierCount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();
            int messagesCount = int.Parse(Console.ReadLine());

            string starPattern = @"[SsTtAaRr]";
            string messagePattern = @"\@(?<Planet>[A-z][a-z]+)[^\@\-\!\:\>]*:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*->(?<soldiers>\d+)[^\@\-\!\:\>]*";

            for (int i = 0; i < messagesCount; i++)
            {
                string encrypt = Console.ReadLine();

                int decryptionKey = Regex.Matches(encrypt, starPattern).Count;

                StringBuilder messageBuilder = new StringBuilder();
                for (int j = 0; j < encrypt.Length; j++)
                {
                    messageBuilder.Append((char)(encrypt[j] - decryptionKey));
                }

                string decryptedMessage = messageBuilder.ToString();

                Match match = Regex.Match(decryptedMessage, messagePattern);
                if(!Regex.IsMatch(decryptedMessage, messagePattern))
                {
                    continue;
                }

                string planetName = match.Groups["Planet"].Value;
                uint population = uint.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["type"].Value;
                uint soldierCount = uint.Parse(match.Groups["soldiers"].Value);
                Message message = new Message(planetName,population,attackType,soldierCount);

                messages.Add(message);
            }


            List<Message> planetsA = messages.Where(x => x.AttackType == "A")
                .OrderBy(x => x.PlanetName)
                .ToList();

            Console.WriteLine($"Attacked planets: {planetsA.Count}");
            planetsA.ForEach(x => Console.WriteLine($"-> {x.PlanetName}"));

            List<Message> planetsD = messages.Where(x => x.AttackType == "D")
                .OrderBy(x => x.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planetsD.Count}");
            planetsD.ForEach(x => Console.WriteLine($"-> {x.PlanetName}"));
        }
    }
}
