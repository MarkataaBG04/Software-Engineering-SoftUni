namespace _21.Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            string product = Console.ReadLine();
            int count = 0;
            double priceProducts =0;

            while (product != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                count++;


                if (count % 3 == 0)
                {
                    price /= 2;
                }
                
                if (budjet >= price)
                {
                    budjet -= price;
                    priceProducts += price;
                }
                else
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(price - budjet):f2} leva!");
                    return;
                }

                product = Console.ReadLine();
                
            }

            Console.WriteLine($"You bought {count} products for {priceProducts:f2} leva.");
        }
    }
}