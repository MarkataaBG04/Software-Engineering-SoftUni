using System;

namespace _03.MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Player> players = new Dictionary<string, Player>();
            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    // Формат 1: player -> position -> skill
                    string[] parts = input.Split(" -> ");
                    string player = parts[0];
                    string position = parts[1];
                    int skill = int.Parse(parts[2]);

                    if (!players.ContainsKey(player))
                    {
                        Player newPlayer = new Player(player, position, skill);
                        players.Add(player, newPlayer);
                        players[player].RoleStats.Add(position, skill);
                    }
                    else
                    {
                        if (players[player].RoleStats.ContainsKey(position))
                        {
                            if (players[player].RoleStats[position] < skill)
                            {
                                players[player].RoleStats[position] = skill;
                            }
                        }
                        else
                        {
                            players[player].RoleStats.Add(position, skill);
                        }
                    }
                }
                else if (input.Contains("vs"))
                {
                    // Формат 2: player vs player
                    string[] parts = input.Split(" vs ");
                    string player1 = parts[0];
                    string player2 = parts[1];

                    // обработваш битка между двама

                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        // Проверка за обща позиция
                        bool hasCommonPosition = false;
                        foreach (var pos in players[player1].RoleStats.Keys)
                        {
                            if (players[player2].RoleStats.ContainsKey(pos))
                            {
                                hasCommonPosition = true;
                                break;
                            }
                        }

                        if (hasCommonPosition)
                        {
                            int totalSkill1 = players[player1].RoleStats.Values.Sum();
                            int totalSkill2 = players[player2].RoleStats.Values.Sum();

                            if (totalSkill1 > totalSkill2)
                            {
                                players.Remove(player2);
                            }
                            else if (totalSkill2 > totalSkill1)
                            {
                                players.Remove(player1);
                            }
                        }
                    }


                }

            }

            PrintResult(players);

        }

        private static void PrintResult(Dictionary<string, Player> players)
        {
            foreach (var player in players.OrderByDescending(p => p.Value.RoleStats.Values.Sum()) // общ skill спадащо
                                                                                .ThenBy(p => p.Key))
            {
                int totalSkill = player.Value.RoleStats.Values.Sum();
                Console.WriteLine($"{player.Key}: {totalSkill} skill");

                foreach (var pos in player.Value.RoleStats
                                                .OrderByDescending(r => r.Value) // skill спадащо
                                                .ThenBy(r => r.Key))            // име на позиция възходящо
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }

    class Player 
    {
        public Player(string name, string position, int skill)
        {
            Name = name;
            RoleStats = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public Dictionary<string, int> RoleStats { get; set; }
    }
}
