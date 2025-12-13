namespace _57.Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            int winCount = 0;
            int drawCount = 0;
            int loseCount = 0;
            int points = 0;

            for (int i = 1; i <= playedGames; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    winCount++;
                    points += 3;
                }
                else if (result == "D")
                {
                    drawCount++;
                    points += 1;
                }
                else if (result == "L")
                {
                    loseCount++;
                    points += 0;
                }
            }
            if (playedGames <= 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                
            }
            else 
            {
                Console.WriteLine($"{team} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {winCount}");
                Console.WriteLine($"## D: {drawCount}");
                Console.WriteLine($"## L: {loseCount}");
                Console.WriteLine($"Win rate: {(double)winCount/playedGames * 100:f2}%");
            }
        }
    }
}
