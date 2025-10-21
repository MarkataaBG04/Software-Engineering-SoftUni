using static System.Net.Mime.MediaTypeNames;

namespace _03.Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int winCount  = 0;
            int loseCount  = 0;
            int drawCount  = 0;

            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();
                string[] parts = result.Split(':');

                // Взимаме първата и втората стойност
                int first = int.Parse(parts[0]);
                int second = int.Parse(parts[1]);

                if (first > second)
                {
                    winCount++;
                }
                else if (first == second)
                {
                    drawCount++;
                }
                else
                {
                    loseCount++;
                }


 
            }

            Console.WriteLine($"Team won {winCount} games.");
            Console.WriteLine($"Team lost {loseCount} games.");
            Console.WriteLine($"Drawn games: {drawCount}");
        }
    }
}