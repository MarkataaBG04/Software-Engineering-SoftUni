namespace _40.Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());

            double average = 0;

            for (int i = 1; i <= customers; i++) 
            {
                string product = Console.ReadLine();
                double price = 0;
                int productCount = 0;
                while (product != "Finish")
                {
                    productCount++;
                    if (product == "basket")
                    {
                        price += 1.5;
                    }
                    else if (product == "wreath")
                    {
                        price += 3.8;
                    }
                    else if (product == "chocolate bunny")
                    {
                        price += 7.0;
                    }

                        product = Console.ReadLine();
                }
                if (productCount % 2 == 0)
                {
                    price = price - (price * 0.20);
                }

                Console.WriteLine($"You purchased {productCount} items for {price:f2} leva.");

                average += price;
            }

            Console.WriteLine($"Average bill per client is: {average / customers:f2} leva.");
        }
    }
}
