namespace _19.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double litersNeed = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double price = litersNeed * 2.10 + 100;

            if (day == "Saturday")
            {
                price -= price * 0.10;
            }
            else
            {
                price -= price * 0.20;
            }



            if (budjet >= price)
            {
                Console.WriteLine($"Safari time! Money left: {budjet-price:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price-budjet:f2} lv.");
            }


        }
    }
}