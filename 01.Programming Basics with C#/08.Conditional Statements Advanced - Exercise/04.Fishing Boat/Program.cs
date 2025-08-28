namespace _04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bubjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int humans = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;
                if (humans <= 6)
                {
                    price = price * 0.90;
                }
                else if (humans >= 7 && humans <= 11)
                {
                    price = price * 0.85;
                }
                else
                {
                    price = price * 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
                if (humans <= 6)
                {
                    price = price * 0.90;
                }
                else if (humans >= 7 && humans <= 11)
                {
                    price = price * 0.85;
                }
                else
                {
                    price = price * 0.75;
                }
            }
            else
            {
                price = 2600;
                if (humans <= 6)
                {
                    price = price * 0.90;
                }
                else if (humans >= 7 && humans <= 11)
                {
                    price = price * 0.85;
                }
                else
                {
                    price = price * 0.75;
                }
            }
            //additional discount 
            if (season != "Autumn")
            {
                if (humans % 2 == 0)
                {
                    price = price * 0.95;
                }
            }

            //printing the result
            if (bubjet >= price)
            {
                double leftMone = bubjet - price;
                Console.WriteLine($"Yes! You have {leftMone:f2} leva left.");
            }
            else
            {
                double neededMoney = price - bubjet;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}