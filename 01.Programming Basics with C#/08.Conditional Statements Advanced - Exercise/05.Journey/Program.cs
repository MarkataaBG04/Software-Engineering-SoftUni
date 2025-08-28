namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double spendMoney = 0;
            string placeSleep = "";

            if (budjet <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spendMoney = budjet * 0.30;
                    placeSleep = "Camp";
                }
                else
                {
                    spendMoney = budjet * 0.70;
                    placeSleep = "Hotel";
                }
            }
            else if ( budjet <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spendMoney = budjet * 0.40;
                    placeSleep = "Camp";
                }
                else
                {
                    spendMoney = budjet * 0.80;
                    placeSleep = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                placeSleep = "Hotel";
                spendMoney = budjet * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeSleep} - {spendMoney:f2}");
        }
    }
}