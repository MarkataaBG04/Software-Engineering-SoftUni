namespace _24.Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double twentyKgPrice = double.Parse(Console.ReadLine());
            double kgBag = double.Parse(Console.ReadLine());
            int daysUntillTravel = int.Parse(Console.ReadLine());
            int bagsCount = int.Parse(Console.ReadLine());

            double price = 0;

            if (kgBag < 10)
            {
                price = bagsCount *  twentyKgPrice * 0.20;
            }
            else if (kgBag >= 10 && kgBag <= 20)
            {
                price = bagsCount * (twentyKgPrice / 2);
            }
            else if (kgBag > 20)
            {
                price = bagsCount * twentyKgPrice;
            }

            if (daysUntillTravel > 30)
            {
                price = price * 1.10;
            }
            else if (daysUntillTravel >= 7 && daysUntillTravel <= 30)
            {
                price = price * 1.15;
            }
            else if (daysUntillTravel < 7)
            {
                price = price * 1.40;
            }

            Console.WriteLine($"The total price of bags is: {price:f2} lv.");
        }
    }
}