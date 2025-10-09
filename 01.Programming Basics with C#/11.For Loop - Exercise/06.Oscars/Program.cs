namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int nActors = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nActors; i++)
            {
                string nameEvaluator = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());

                startingPoints += ((nameEvaluator.Length * pointsGiven) / 2);

                if (startingPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPoints:F1}!");
                    return;
                }

            }

                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPoints:F1} more!");
            
        }
    }
}