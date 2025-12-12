namespace _41.Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double episodeDuration = double.Parse(Console.ReadLine());

            double ads = episodeDuration * 0.20;
            double episodesDurationWithAds = ads + episodeDuration;
            double specialEpisodesDuration = seasons * 10;
            double timeNeed = episodesDurationWithAds * episodes * seasons + specialEpisodesDuration;

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {Math.Floor(timeNeed)} minutes.");
        }
    }
}
