namespace _58.Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pointsFirst = 0;
            int pointsSecond = 0;

            string drawName = "";
            int bestPoints = int.MinValue;
            string bestName = string.Empty;
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                int points = 0;
                    foreach (char ch in command)
                    {
                    int numbers = int.Parse(Console.ReadLine());
                        if (ch == numbers)
                        {
                            points += 10;
                        }
                        else
                        {
                            points += 2;
                        }
                    }
                

                if (points > bestPoints)
                {
                    bestPoints = points;
                    pointsFirst = points;
                    bestName = command;
                }
                else if (points == bestPoints)
                {
                    drawName = command;
                    pointsSecond = points;
                }
                else
                {
                    pointsSecond = points;
                }

                    command = Console.ReadLine();
            }

            if (pointsFirst > pointsSecond)
            {
                Console.WriteLine($"The winner is {bestName} with {bestPoints} points!");
            }
            else if (pointsFirst < pointsSecond)
            {
                Console.WriteLine($"The winner is {bestName} with {bestPoints} points!");
            }
            else
            {
                Console.WriteLine($"The winner is {drawName} with {bestPoints} points!");
            }
            
        }
    }
}
