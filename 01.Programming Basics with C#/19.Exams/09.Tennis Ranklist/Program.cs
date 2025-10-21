namespace _09.Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());


            double newPoints = 0;

            double winCount = 0;


            for (int i = 1; i <= tournamentsCount; i++)
            {
                string place = Console.ReadLine();

                if (place == "W")
                {
                    newPoints += 2000;
                    winCount++;
                }
                else if (place == "F")
                {
                    newPoints += 1200;
                }
                else if (place == "SF")
                {
                    newPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + newPoints}");
            Console.WriteLine($"Average points: {Math.Floor(newPoints / tournamentsCount)}");
            Console.WriteLine($"{winCount / tournamentsCount * 100:f2}%");
        }
    }
}