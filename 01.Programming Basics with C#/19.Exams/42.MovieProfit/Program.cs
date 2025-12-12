namespace _42.MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentKino = int.Parse(Console.ReadLine());

            double profit =(tickets * priceTicket) * days;

            profit = profit - (profit * (percentKino / 100.0));

            Console.WriteLine($"The profit from the movie {movieName} is {profit:f2} lv.");

        }
    }
}
