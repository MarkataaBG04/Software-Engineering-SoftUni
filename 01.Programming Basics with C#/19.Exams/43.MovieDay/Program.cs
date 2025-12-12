namespace _43.MovieDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForScenes = int.Parse(Console.ReadLine());
            int totalScenes = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());

            double areaTime = timeForScenes * 0.15;
            double totalTime = (totalScenes * duration) + areaTime;

            if (totalTime <= timeForScenes)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForScenes - totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTime - timeForScenes)} minutes.");
            }
        }
    }
}
