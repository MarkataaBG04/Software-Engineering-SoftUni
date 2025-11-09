namespace _30.Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double flourPriceKg = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsPacks = int.Parse(Console.ReadLine());
            int cookingMayPacks = int.Parse(Console.ReadLine());

            double sugarpPrice = flourPriceKg * 0.75;
            double eggsPrice = flourPriceKg * 1.10;
            double cookingMayPrice = sugarpPrice * 0.20;

            double totalPrice = (flourPriceKg * kgFlour) + (sugarpPrice * sugarKg) + (eggsPacks * eggsPrice) + (cookingMayPacks * cookingMayPrice);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}