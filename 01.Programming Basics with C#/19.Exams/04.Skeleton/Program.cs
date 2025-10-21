namespace _04.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesRequired = int.Parse(Console.ReadLine());
            int secondsReuqired = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int hundredMetersSecond = int.Parse(Console.ReadLine());

            int totalTimeRequired = minutesRequired * 60 + secondsReuqired;

            double totalTimesDelay = (lenght / 120) * 2.5;

            double martinTime = (lenght / 100) * hundredMetersSecond - totalTimesDelay;

            if (martinTime <= totalTimeRequired)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {martinTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {martinTime-totalTimeRequired:f3} second slower.");
            }
        }
    }
}