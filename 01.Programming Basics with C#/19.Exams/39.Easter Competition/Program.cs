namespace _39.Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunaksNum = int.Parse(Console.ReadLine());

            string bestName = "";
            
            int bestPoints = int.MinValue;

            for (int i = 1; i <= kozunaksNum; i++) 
            {
                int points = 0;
                string chefName = Console.ReadLine();
                string command = Console.ReadLine();
                while (command != "Stop")
                {
                    int pointsPerPerson = int.Parse(command);

                    points += pointsPerPerson;

                    command = Console.ReadLine();
                }
               
                Console.WriteLine($"{chefName} has {points} points.");
                if (bestPoints < points)
                {
                    Console.WriteLine($"{chefName} is the new number 1!");
                    bestPoints = points;
                    bestName = chefName;
                }
            }

            Console.WriteLine($"{bestName} won competition with {bestPoints} points!");
        }
    }
}
