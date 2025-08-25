namespace _04.Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzelsCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalPrice = (puzzelsCount * 2.60) + (dollsCount * 3) + (bearsCount * 4.1) + (minionsCount * 8.2) + (trucksCount * 2);

           int totalToys = puzzelsCount + dollsCount + bearsCount + minionsCount + trucksCount;

            if (totalToys >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }

            double rent = 0.10;

            totalPrice = totalPrice - (totalPrice * rent);


            if (totalPrice >= priceExcursion)
            {
                Console.WriteLine($"Yes! {totalPrice - priceExcursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(priceExcursion - totalPrice):f2} lv needed.");
            }

        }
    }
}