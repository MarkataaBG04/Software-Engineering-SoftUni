namespace _01.Tennis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            int rocketsCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double price = (rocketsCount * tennisRocketPrice) + ((tennisRocketPrice / 6) * shoesCount);
            price = price * 1.20;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(price / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(price * 7/8)}");
        }
    }
}