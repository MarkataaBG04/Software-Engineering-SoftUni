namespace _06.Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactiCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalPrice = (magnoliasCount * 3.25) + (hyacinthsCount * 4) + (rosesCount * 3.5) + (cactiCount * 8);

            totalPrice = totalPrice - (totalPrice * 0.05);

            if (totalPrice >= giftPrice)
            {
                double leftMoney = totalPrice - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
            }
            else
            {
                double neededMoney = giftPrice - totalPrice;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(neededMoney)} leva.");
            }
        }
    }
}