namespace _10.Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int proteinShakeCount = 0;
            int proteinBarCount = 0;

            int workoutCount = 0;
            int protein = 0;

            for (int i = 1; i <= peopleCount; i++)
            {
                string activity = Console.ReadLine();

                if (activity == "Back")
                {
                    backCount++;
                    workoutCount++;
                }
                else if (activity == "Chest")
                {
                    chestCount++;
                    workoutCount++;
                }
                else if (activity == "Legs")
                {
                    legsCount++;
                    workoutCount++;
                }
                else if (activity == "Abs")
                {
                    absCount++;
                    workoutCount++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShakeCount++;
                    protein++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBarCount++;
                    protein++;
                }
            }

            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            Console.WriteLine($"{(double)workoutCount / peopleCount * 100:f2}% - work out");
            Console.WriteLine($"{(double)protein / peopleCount * 100:f2}% - protein");
        }
    }
}