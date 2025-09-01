namespace _04.Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classType = "";
            string carType = "";

            if (budjet <= 100)
            {
                classType = "Economy class";
                if (season == "Summer")
                {
                    budjet = budjet * 0.35;
                    carType = "Cabrio";
                }
                else
                {
                    budjet = budjet * 0.65;
                    carType = "Jeep";
                }
            }
            else if (budjet > 100 && budjet <= 500)
            {
                classType = "Compact class";
                if (season == "Summer")
                {
                    budjet = budjet * 0.45;
                    carType = "Cabrio";
                }
                else
                {
                    budjet = budjet * 0.80;
                    carType = "Jeep";
                }
            }
            else if (budjet > 500)
            {
                classType = "Luxury class";
                carType = "Jeep";
                budjet = budjet * 0.90;
            }

            Console.WriteLine($"{classType}");
            Console.WriteLine($"{carType} - {budjet:f2}");
        }
    }
}