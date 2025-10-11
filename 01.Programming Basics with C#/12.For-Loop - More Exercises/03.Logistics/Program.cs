namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            int totalTons = 0;

            int busCount = 0;
            int truckCount = 0;
            int trainCount = 0;

            for (int i = 1; i <= numberOfLoads; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());

                totalTons += cargoWeight;

                if (cargoWeight <= 3)
                {
                    busCount += cargoWeight;
                }
                else if (cargoWeight >= 4 && cargoWeight <= 11)
                {
                    truckCount += cargoWeight;
                }
                else if(cargoWeight >= 12)
                {
                     trainCount += cargoWeight;
                }
            }

            double averagePrice = ((busCount * 200.0) + (truckCount * 175.0) + (trainCount * 120.0)) / totalTons;

            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{(double)busCount / totalTons * 100:F2}%");
            Console.WriteLine($"{(double)truckCount / totalTons * 100:f2}%");
            Console.WriteLine($"{(double)trainCount / totalTons * 100:f2}%");
        }
    }
}