namespace _02.Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int catPlayMin = 30000;

            int workingDays = 365 - daysOff;

            int totalPlay = (workingDays * 63) + (daysOff * 127);

            
            if (catPlayMin < totalPlay)
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{(totalPlay - catPlayMin) / 60} hours and {(totalPlay - catPlayMin) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{(catPlayMin - totalPlay) / 60} hours and {(catPlayMin - totalPlay) % 60} minutes less for play");
            }

        }
    }
}