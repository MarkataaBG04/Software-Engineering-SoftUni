namespace _02.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearPrice = int.Parse(Console.ReadLine());

            double shoes = yearPrice - (yearPrice * 0.40);
            double kit = shoes - (shoes * 0.20);
            double ball = kit / 4;
            double others = ball / 5;

            double total = yearPrice + shoes + kit + ball + others;

            Console.WriteLine($"{total:f2}");
        }
    }
}