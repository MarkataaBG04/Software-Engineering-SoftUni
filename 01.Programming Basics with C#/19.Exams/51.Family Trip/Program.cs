namespace _51.Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int sleeps = int.Parse(Console.ReadLine());
            double pricePerSleep = double.Parse(Console.ReadLine());
            int percentAdditionalSpends = int.Parse(Console.ReadLine());

            if (sleeps > 7)
            {
                pricePerSleep -= pricePerSleep * 0.05;
            }

            double totalSum = pricePerSleep * sleeps;

            totalSum += budget * (percentAdditionalSpends / 100.0);

            if (totalSum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalSum:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalSum-budget:f2} leva needed.");
            }
        }
    }
}
