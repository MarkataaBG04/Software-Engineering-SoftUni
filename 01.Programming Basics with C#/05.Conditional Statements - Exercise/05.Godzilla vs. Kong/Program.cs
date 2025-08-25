namespace _05.Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = 0.10;

            double spendings = 0;

            if (workers > 150)
            {
                priceClothes = priceClothes - (priceClothes * 0.10);
            }

            double totalMoneyClothes = priceClothes * workers;

            spendings = (budjet * decor) + totalMoneyClothes;

            if (spendings > budjet)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budjet - spendings):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budjet - spendings:F2} leva left.");
            }

        }
    }
}