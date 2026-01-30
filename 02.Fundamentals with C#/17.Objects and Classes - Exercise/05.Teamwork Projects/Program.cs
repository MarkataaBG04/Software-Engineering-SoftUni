namespace _05.Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            string input = "";

            for (int i = 1; i <= countOfTeams; i++)
            {
                input = Console.ReadLine();
                string[] arguments = input.Split("-");

                Team team = new Team(arguments[0], arguments[1]);

                bool isTeamExists = teams.Exists(team => team.TeamName == arguments[1]);
                bool isUserCreatingNew = teams.Exists(team => team.Creator == arguments[0]);

                if (isTeamExists)
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }
                else if (isUserCreatingNew)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                }
            }
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = input.Split("->");
                string user = arguments[0];
                string teamName = arguments[1];

                Team existingTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(team => team.Creator == user || team.Member.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    existingTeam.Member.Add(user);
                }
            }

            List<Team> sortedTeams = teams
                                .Where(t => t.Member.Count > 0) // само активни отбори
                                .OrderByDescending(t => t.Member.Count) // първо по брой членове
                                .ThenBy(t => t.TeamName)             // второ по име на отбора
                                .ToList();

            foreach (Team team in sortedTeams) 
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Member.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandTeams = teams
                             .Where(t => t.Member.Count == 0)
                             .OrderBy(t => t.TeamName)
                             .ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var t in disbandTeams)
            {
                Console.WriteLine(t.TeamName);
            }
        }
    }
    class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Member = new List<string>();
        }

        public string Creator { get; set; }

        public string TeamName { get; set; }

        public List<string> Member { get; set; }
    }
}

            

    

