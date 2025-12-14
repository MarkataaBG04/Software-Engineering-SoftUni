namespace _62.Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int walksCount = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int totalBurnedCalories = (minutesWalking * walksCount) * 5;

            double needBurnCalories = caloriesPerDay / 2;

            if (totalBurnedCalories >= needBurnCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurnedCalories}.");
            }
        }
    }
}
