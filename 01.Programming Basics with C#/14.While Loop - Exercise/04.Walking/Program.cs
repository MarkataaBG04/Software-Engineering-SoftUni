namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;

            string command = Console.ReadLine();

            int sumOfSteps = 0;

            while (command != "Going home")
            {
                int steps = int.Parse(command);

                sumOfSteps += steps;

                if (sumOfSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - stepsGoal} steps over the goal!");
                    return;
                }

                command = Console.ReadLine();
            }
            int stepsHome = int.Parse(Console.ReadLine());
            sumOfSteps += stepsHome;
            if (sumOfSteps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{sumOfSteps - stepsGoal} steps over the goal!");

            }
            else
            {
                Console.WriteLine($"{stepsGoal - sumOfSteps} more steps to reach goal.");
            }
            
            
        }
    }
}