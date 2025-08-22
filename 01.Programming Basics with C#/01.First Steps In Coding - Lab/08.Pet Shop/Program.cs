namespace _08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());


            double totalSum = (dogFoodCount * 2.5) + (catFoodCount * 4);

            Console.WriteLine($"{totalSum} lv.");
        }
    }
}