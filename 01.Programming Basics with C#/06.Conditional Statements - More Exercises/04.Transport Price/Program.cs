namespace _04.Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double taxiPrice = 0;

            double busPrice = 0;
            double trainPrice = 0;

            if (day == "day")
            {
                taxiPrice = 0.70 + (n * 0.79);
            }
            else if (day == "night")
            {
                taxiPrice = 0.70 + (n * 0.90);
            }

            if (n >= 100)
            {
                trainPrice = n * 0.06;
                busPrice = n * 0.09;
                if (taxiPrice <= busPrice && taxiPrice <= busPrice)
                {
                    Console.WriteLine($"{taxiPrice:f2}");
                }
                else if (busPrice <= taxiPrice && busPrice <= trainPrice)
                {
                    Console.WriteLine($"{busPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"{trainPrice:f2}");
                }
            }
            else if (n >= 20)
            {
                busPrice = n * 0.09;

                if (busPrice <= taxiPrice)
                {
                    Console.WriteLine($"{busPrice:f2}");
                }
            }
            else
            {
                Console.WriteLine($"{taxiPrice:F2}");
            }
        }
    }
}