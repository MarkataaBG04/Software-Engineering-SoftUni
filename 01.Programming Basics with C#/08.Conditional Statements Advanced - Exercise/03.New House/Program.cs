namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowersType == "Roses")
            {
                totalPrice = quantity * 5;
                if (quantity > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }
            }
            else if (flowersType == "Dahlias")
            {
                totalPrice = quantity * 3.80;
                if (quantity > 90)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }
            else if (flowersType == "Tulips")
            {
                totalPrice = quantity * 2.80;
                if (quantity > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);

                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = quantity * 3;
                if (quantity < 120)
                {
                    totalPrice = totalPrice * 1.15;
                }
            }
            else
            {
                totalPrice = quantity * 2.50;
                if (quantity < 80)
                {
                    totalPrice = totalPrice * 1.20;
                }
            }

            if (budjet >= totalPrice)
            {
                double leftMoney = budjet - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowersType} and {leftMoney:f2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budjet;
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}