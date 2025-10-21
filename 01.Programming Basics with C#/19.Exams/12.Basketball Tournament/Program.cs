namespace _12.Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();



            int totalMatches = 0;
            int loses =0;
            int wins = 0;


            while (tournament != "End of tournaments")
            {
               int nGames = int.Parse(Console.ReadLine());
                for (int i = 1; i <= nGames; i++)
                {
                    int pointsDesi = int.Parse(Console.ReadLine());
                    int enemyDesi = int.Parse(Console.ReadLine());

                    if (pointsDesi > enemyDesi)
                    {
                        wins++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {pointsDesi - enemyDesi} points.");
                    }
                    else if (enemyDesi > pointsDesi)
                    {
                        loses++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {enemyDesi - pointsDesi} points.");
                    }
                    totalMatches++;
                }
                tournament = Console.ReadLine();
                
            }


            Console.WriteLine($"{(double)wins/totalMatches*100:f2}% matches win");
            Console.WriteLine($"{(double)loses/totalMatches*100:f2}% matches lost");

        }
    }
}