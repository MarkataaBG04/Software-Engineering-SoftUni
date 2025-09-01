namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = Console.ReadLine();
            string placeForSleep = Console.ReadLine();

            if (budjet <= 1000)
            {
                placeForSleep = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budjet = budjet * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budjet = budjet * 0.45;
                }
            }
            else if (budjet > 1000 && budjet <= 3000)
            {
                placeForSleep = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budjet = budjet * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budjet = budjet * 0.60;
                }
            }
            else if (budjet > 3000)
            {
                placeForSleep = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budjet = budjet * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budjet = budjet * 0.90;
                }
            }

            Console.WriteLine($"{location} - {placeForSleep} - {budjet:f2}");
        }
    }
}