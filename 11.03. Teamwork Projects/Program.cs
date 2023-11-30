using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _11._03._Teamwork_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Teams> team = new List<Teams>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] teamsDate = Console.ReadLine().Split("-");
                string creator = teamsDate[0];
                string teamName = teamsDate[1];

                // Check if the team with the same creator already exists
                if (team.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                // Check if the team with the same name already exists
                if (team.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                // Create a new team and add it to the list
                Teams currentTeam = new Teams(creator, teamName);
                team.Add(currentTeam);


                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] userTeamData = command.Split("->");
                string user = userTeamData[0];
                string teamName = userTeamData[1];

                Teams currentTeams = team.FirstOrDefault(t => t.TeamName == teamName);

                // Check if the team with the specified name exists
                if (!team.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                var currentTeam = team.First(t => t.TeamName == teamName);

                // Check if the user is already a member of the team
                if (currentTeam.Creator == user || currentTeam.Members.Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    command = Console.ReadLine();
                    continue;
                }

                // Add the user to the team
                currentTeam.Members.Add(user);

                command = Console.ReadLine();
            }

            // Separate valid teams from disbanded teams
            var validTeams = team
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            var disbandedTeams = team
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            // Print valid teams
            foreach (var validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.TeamName}");
                Console.WriteLine($"- {validTeam.Creator}");
                foreach (var member in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            // Print disbanded teams
            Console.WriteLine("Teams to disband:");
            foreach (var disbandedTeam in disbandedTeams)
            {
                Console.WriteLine($"{disbandedTeam.TeamName}");
            }
        }
    }
}