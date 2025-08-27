namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dogFoodDay = double.Parse(Console.ReadLine());//kg
            double catFoodDay = double.Parse(Console.ReadLine()); //kg
            double turtleFoodDay = double.Parse(Console.ReadLine()) / 1000; //kg

            double totalFoodEaten = (dogFoodDay * days) + (catFoodDay * days) + (turtleFoodDay * days);

            if (kgFood >= totalFoodEaten)
            {
                double leftFodd = kgFood - totalFoodEaten;
                Console.WriteLine($"{Math.Floor(leftFodd)} kilos of food left.");
            }
            else
            {
                double neededFood = totalFoodEaten - kgFood;
                Console.WriteLine($"{Math.Ceiling(neededFood)} more kilos of food are needed.");
            }
        }
    }
}