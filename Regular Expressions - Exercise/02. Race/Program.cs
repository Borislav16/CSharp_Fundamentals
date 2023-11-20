using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public uint Distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participantName = Console.ReadLine().Split(", ").ToList();
            List<Participant> participants = new List<Participant>();

            foreach (string name in participantName)
            {
                Participant participant = new Participant(name);
                participants.Add(participant);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                string lettersPattern = @"[A-Za-z]";
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    sb.Append(match.Value);
                }

                string pName = sb.ToString();

                uint distance = 0;
                string digitsPattern = @"\d";
                foreach (Match match in Regex.Matches(input, digitsPattern))
                {
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(p => p.Name == pName);
                if(foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                
                }
            }

            List<Participant> firstParticipants = participants
                .OrderByDescending(p => p.Distance)
                .Take(3)
                .ToList();

            Console.WriteLine($"1st place: {firstParticipants[0].Name}");
            Console.WriteLine($"2nd place: {firstParticipants[1].Name}");
            Console.WriteLine($"3rd place: {firstParticipants[2].Name}");

        }
    }
}
