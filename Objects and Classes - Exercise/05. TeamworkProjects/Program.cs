using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TeamworkProjects
{
    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMembersString()}";
        }
        private string GetMembersString()
        {
            Members = Members
                .OrderBy(name => name)
                .ToList();

            string result = "";
            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }

            result += $"-- {Members[Members.Count - 1]}";
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split("-");
                string teamName = arguments[1];
                string creatorName = arguments[0];

                Team team = new Team(teamName, creatorName);
                Team sameTeam = teams.Find(team => team.Name == teamName);
                Team sameCreator = teams.Find(team => team.Creator == creatorName);

                if (sameTeam != null)
                {
                    Console.WriteLine($"Team {sameTeam.Name} was already created!");
                    continue;
                }
                if (sameCreator != null)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }


                teams.Add(team);


                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string memberName = arguments[0];
                string teamName = arguments[1];

                if(!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if(teams.Any(t => t.Creator == memberName) ||
                    teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                Team foundTeam = teams.Find(team => team.Name == teamName);
                foundTeam.Members.Add(memberName);
            }

            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(team => team.Members.Count <= 0);

            validTeams = validTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name).ToList();

            disbandTeams = disbandTeams.OrderBy(team => team.Name).ToList();
            


            foreach (Team team in validTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
