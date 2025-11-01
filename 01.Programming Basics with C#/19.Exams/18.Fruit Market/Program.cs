namespace _18.Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberiesPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberiesQuantites = double.Parse(Console.ReadLine());
            double stawberiesQuantity = double.Parse(Console.ReadLine());

            double priceRaspberies = (strawberiesPrice / 2);
            double orangaesPrice = priceRaspberies - (priceRaspberies * 0.40);
            double bananasPrice = priceRaspberies - (priceRaspberies * 0.80);



            double price = (stawberiesQuantity * strawberiesPrice) + (raspberiesQuantites * priceRaspberies) + (bananasPrice * bananasQuantity) + (orangaesPrice * orangesQuantity);

            Console.WriteLine($"{price:f2}");
        }
    }
}