namespace _68.Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double planeCapacity = double.Parse(Console.ReadLine());
            int luggageCount = 0;
            int suitcasesCount = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                double luggageWeight = double.Parse(command);
                luggageCount++;

                // всеки трети куфар +10%
                if (luggageCount % 3 == 0)
                {
                    luggageWeight *= 1.10;
                }

                if (planeCapacity < luggageWeight)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcasesCount} suitcases loaded.");
                    return;
                }

                planeCapacity -= luggageWeight;
                suitcasesCount++;

                command = Console.ReadLine();
            }

            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitcasesCount} suitcases loaded.");
        }
    }
}
