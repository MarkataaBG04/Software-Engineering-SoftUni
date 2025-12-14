namespace _63.Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double delay = (Math.Floor(distanceInMeters / 50) * 30);

            double competitorTime = (distanceInMeters * timeForOneMeter) + delay;

            if (competitorTime < record)
            {
                Console.WriteLine($"Yes! The new record is {competitorTime:f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No! He was {competitorTime - record:f2} seconds slower.");
            }
        }
    }
}
