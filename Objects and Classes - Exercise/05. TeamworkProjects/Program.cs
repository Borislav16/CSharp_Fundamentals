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
            string result = "";
            result += Name + "\n";
            result += $"- {Creator}\n";
            foreach (string member in Members)
            {
                result += $"-- {member}\n";
            }
            return result.Trim();
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
                string creatorTeamString = Console.ReadLine();
                string[] arguments = creatorTeamString.Split("-");
                string creatorName = arguments[0];
                string teamName = arguments[1];

                Team team = new Team(teamName, creatorName);

                Team sameCreator = teams.Find(team => team.Creator == creatorName);
                if (sameCreator != null)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                Team sameTeam = teams.Find(team => team.Name == teamName);
                if (sameTeam != null)
                {
                    Console.WriteLine($"Team {sameTeam.Name} was already created!");
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

                Team exist = null;
                foreach (Team team in teams)
                {
                    if (team.Members.Contains(memberName))
                    {
                        exist = team;
                        break;
                    }
                }


                if (exist != null)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;

                }


                Team foundTeam = teams.Find(team => team.Name == teamName);
                if (foundTeam != null)
                {
                    if (foundTeam.Creator == memberName)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    }
                    else
                    {
                        foundTeam.Members.Add(memberName);

                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(team => team.Members.Count == 0);

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
