using System.ComponentModel;

namespace _02.Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int youngBikers = int.Parse(Console.ReadLine());
            int oldBikers = int.Parse(Console.ReadLine());
            string roadKind = Console.ReadLine();


            double totalMoney = 0;
            int totalPeople = youngBikers + oldBikers;

            if (roadKind == "trail")
            {
                totalMoney = (oldBikers * 7) + (youngBikers * 5.5);
            }
            else if (roadKind == "cross-country")
            {
                totalMoney = (oldBikers * 9.5) + (youngBikers * 8);
                if (totalPeople >= 50)
                {
                    totalMoney = totalMoney * 0.75;
                }
            }
            else if (roadKind == "downhill")
            {
                totalMoney = (oldBikers * 13.75) + (youngBikers * 12.25);
            }
            else if (roadKind == "road")
            {
                totalMoney = (oldBikers * 21.50) + (youngBikers * 20);
            }

            totalMoney = totalMoney * 0.95;

            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}