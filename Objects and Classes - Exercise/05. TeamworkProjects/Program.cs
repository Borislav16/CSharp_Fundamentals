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
            Member = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Member { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMember()}";
        }
        private string GetMember()
        {
            Member = Member.OrderBy(name => name).ToList();

            string result = string.Empty;

            for (int i = 0; i < Member.Count - 1; i++)
            {
                result += $"-- {Member[i]}\n";
            }
            result += $"-- {Member[Member.Count - 1]}";

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamCommands = Console.ReadLine().Split("-");
                string teamName = teamCommands[1];
                string creatorName = teamCommands[0];
                Team team = new Team(teamName, creatorName);

                Team sameTeamFound = teams.Find(t => t.Name == team.Name);
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {sameTeamFound.Name} was already created!");
                    continue;
                }

                Team sameCreatorFound = teams.Find(t => t.Creator ==  team.Creator);
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{sameCreatorFound.Creator} cannot create another team!");
                    continue;
                }


                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");

                string joinerName = arguments[0];
                string teamName = arguments[1];

                bool hasAnyTeamWithSameName = teams.Any(t => t.Name == teamName);
                if(hasAnyTeamWithSameName == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if(teams.Any(team => team.Creator == joinerName) ||
                       teams.Any(team => team.Member.Contains(joinerName)))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                    continue;
                }

                teams.FirstOrDefault(t => t.Name == teamName).Member.Add(joinerName);

            }

            List<Team> leftTeams = teams.Where(t => t.Member.Count > 0).ToList();
            List<Team> orderedTeams = leftTeams.OrderByDescending(t => t.Member.Count).ThenBy(t => t.Name).ToList();

            orderedTeams.ForEach(team => Console.WriteLine(team));

            List<Team> disbandTeams = teams.Where(t => t.Member.Count <= 0).ToList();

            Console.WriteLine("Teams to disband:");

            disbandTeams = disbandTeams.OrderBy(t => t.Name).ToList();

            disbandTeams.ForEach(team => Console.WriteLine(team));
        }
    }
}
