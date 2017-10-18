namespace Pr09TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pr09TeamworkProjects
    {
        public static void Main()
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var creatorAndTeam = Console.ReadLine().Split('-');

                Team team = new Team();
                
                var teamName = teams.FirstOrDefault(t => t.TeamName.Equals(creatorAndTeam[1]));

                var teamCreator = teams.FirstOrDefault(tc => tc.CreatorName.Equals(creatorAndTeam[0]));

                if (!teams.Contains(teamName) && !teams.Contains(teamCreator))
                {
                    var members = new List<string>();

                    team.CreatorName = creatorAndTeam[0];
                    team.TeamName = creatorAndTeam[1];
                    members.Add(team.CreatorName);

                    team.Members = members;

                    teams.Add(team);
                    
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                }

                else if (teams.Contains(teamName) )
                {
                    Console.WriteLine($"Team {creatorAndTeam[1]} was already created!");
                }
                
                else
                {
                    Console.WriteLine($"{creatorAndTeam[0]} cannot create another team!");
                }

               
            }

            var requests = Console.ReadLine();

            while (!requests.Equals("end of assignment"))
            {
                var requestTokens = requests.Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries);

                var requesterName = requestTokens[0];
                var requestedTeam = requestTokens[1];

                var member = teams.FirstOrDefault(u =>
                    u.CreatorName.Equals(requesterName) && u.TeamName.Equals(requestedTeam));

               
                var team = teams.FirstOrDefault(t => t.TeamName.Equals(requestedTeam));

                var memberName = teams.FirstOrDefault(n => n.Members.Contains(requesterName));

                if (teams.Contains(member) || teams.Contains(memberName))
                {
                    Console.WriteLine($"Member {requesterName} cannot join team {requestedTeam}!");
                }
                                
                else if (!teams.Contains(team))
                {
                    Console.WriteLine($"Team {requestedTeam} does not exist!");
                }
                
                else if (teams.Contains(member))
                {
                    Console.WriteLine($"Team {requestedTeam} has been created by {requesterName}!");
                }

                else
                {
                    team.Members.Add(requesterName);
                }

                requests = Console.ReadLine();
            }
            
            List<Team> disbaned = new List<Team>();
            List<Team> regularTeam = new List<Team>();

            foreach (var entity in teams)
            {
                if (entity.Members.Count() == 1)
                {
                    disbaned.Add(entity);
                }

                else
                {
                    regularTeam.Add(entity);
                }
            }

            foreach (var team in regularTeam.OrderByDescending(c => c.Members.Count).ThenBy(n => n.TeamName))
            {
                Console.WriteLine(team.TeamName);

                team.CreatorName = team.Members.First();
                
                Console.WriteLine($"- {team.CreatorName}");

                team.Members.Remove(team.Members.First());

                foreach (var member in team.Members)
                {

                    Console.WriteLine($"-- {member}");
                }
            }
            
            Console.WriteLine("Teams to disband:");
            
            foreach (var team in disbaned.OrderBy(n => n.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
            }

        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}