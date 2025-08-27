namespace _07.Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double currentLiters = double.Parse(Console.ReadLine());

            if (typeFuel == "Diesel")
            {
                if (currentLiters >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else if (typeFuel == "Gasoline")
            {
                if (currentLiters >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else if (typeFuel == "Gas")
            {
                if (currentLiters >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}