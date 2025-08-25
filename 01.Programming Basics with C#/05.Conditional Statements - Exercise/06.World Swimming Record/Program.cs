namespace _06.World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSwimForMeter = double.Parse(Console.ReadLine());

            double delay = (Math.Floor(distanceMeters / 15)) * 12.5;

            double timeForSwim = distanceMeters * timeSwimForMeter;

            double totalTime = (timeForSwim + delay);

            if (totalTime < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordSeconds:f2} seconds slower.");
            }
        }
    }
}