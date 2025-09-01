namespace _06.TruckDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    totalMoney = (kmPerMonth * 0.75) * 4;
                }
                else if (season == "Summer")
                {
                    totalMoney = (kmPerMonth * 0.90) * 4;
                }
                else if (season == "Winter")
                {
                    totalMoney = (kmPerMonth * 1.05) * 4;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    totalMoney = (kmPerMonth * 0.95) * 4;
                }
                else if (season == "Summer")
                {
                    totalMoney = (kmPerMonth * 1.10) * 4;
                }
                else if (season == "Winter")
                {
                    totalMoney = (kmPerMonth * 1.25) * 4;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                totalMoney = (kmPerMonth * 1.45) * 4;
            }

            totalMoney = totalMoney - (totalMoney * 0.10);

            Console.WriteLine($"{totalMoney:F2}");
        }
    }
}