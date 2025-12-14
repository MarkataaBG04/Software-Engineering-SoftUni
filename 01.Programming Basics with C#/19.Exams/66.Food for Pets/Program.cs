namespace _66.Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quanityFood = double.Parse(Console.ReadLine());
            double cookies = 0;
            double dogTotalEaten = 0;
            double catTotalEaten = 0;

            double dayTotalEaten = 0;

            double totalEaten = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFoodEatQuantityDay = int.Parse(Console.ReadLine());
                int catFoodEatQuantityDay = int.Parse(Console.ReadLine());

                dogTotalEaten += dogFoodEatQuantityDay;
                catTotalEaten += catFoodEatQuantityDay;

                totalEaten += dogFoodEatQuantityDay + catFoodEatQuantityDay;

                if (i % 3 == 0)
                {
                    dayTotalEaten = dogFoodEatQuantityDay + catFoodEatQuantityDay;
                    cookies += dayTotalEaten * 0.10;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{totalEaten / quanityFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogTotalEaten/totalEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{catTotalEaten/totalEaten * 100:f2}% eaten from the cat.");
        }
    }
}
