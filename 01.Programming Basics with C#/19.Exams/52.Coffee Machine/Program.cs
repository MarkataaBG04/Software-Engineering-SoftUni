namespace _52.Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coffeeType = Console.ReadLine();
            string sugarOptions = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double totalSum  = 0;

            if (coffeeType == "Espresso")
            {
                if (sugarOptions == "Without")
                {
                    totalSum = 0.90 * count;
                    totalSum -= totalSum * 0.35; 
                }
                else if (sugarOptions == "Normal")
                {
                    totalSum = 1 * count;
                }
                else if (sugarOptions == "Extra")
                {
                    totalSum = 1.20 * count;
                }

                if (count >= 5)
                {
                    totalSum -= totalSum * 0.25;
                }
            }
            else if (coffeeType == "Cappuccino")
            {
                if (sugarOptions == "Without")
                {
                    totalSum = 1 * count;
                    totalSum -= totalSum * 0.35;
                }
                else if (sugarOptions == "Normal")
                {
                    totalSum = 1.20 * count;
                }
                else if (sugarOptions == "Extra")
                {
                    totalSum = 1.60 * count;
                }
            }
            else if (coffeeType == "Tea")
            {
                if (sugarOptions == "Without")
                {
                    totalSum = 0.50 * count;
                    totalSum -= totalSum * 0.35;
                }
                else if (sugarOptions == "Normal")
                {
                    totalSum = 0.60 * count;
                }
                else if (sugarOptions == "Extra")
                {
                    totalSum = 0.70 * count;
                }
            }

            if (totalSum > 15)
            {
                totalSum -= totalSum * 0.20;
            }


            Console.WriteLine($"You bought {count} cups of {coffeeType} for {totalSum:f2} lv.");
        }
    }
}
