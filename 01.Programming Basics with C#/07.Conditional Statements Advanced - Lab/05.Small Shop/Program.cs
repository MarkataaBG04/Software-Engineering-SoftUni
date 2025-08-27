namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.5;
                }
                else if (product == "water")
                {
                    price = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.45;
                }
                else
                {
                    price = quantity * 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.40;
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.30;
                }
                else
                {
                    price = quantity * 1.50;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45;
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.35;
                }
                else
                {
                    price = quantity * 1.55;
                }
            }

            Console.WriteLine($"{price}");
        }
    }
}