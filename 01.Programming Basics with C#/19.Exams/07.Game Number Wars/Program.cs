namespace _07.Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine(); 
            string command = Console.ReadLine();

            int pointsFirst = 0;
            int pointsSecond = 0;

            while (command != "End of game")
            {
                int firstCards = int.Parse(command);
                int secondCards = int.Parse(Console.ReadLine());


                if (firstCards > secondCards)
                {
                    pointsFirst += firstCards - secondCards;
                }
                else if (firstCards < secondCards)
                {
                    pointsSecond += secondCards - firstCards;
                }
                else
                {
                    Console.WriteLine($"Number wars!");
                    command = Console.ReadLine();
                    firstCards = int.Parse(command);
                    secondCards = int.Parse(Console.ReadLine());

                    if (firstCards > secondCards)
                    {
                        Console.WriteLine($"{nameFirst} is winner with {pointsFirst} points");
                        return;
                    }
                    else if (firstCards < secondCards)
                    {
                        Console.WriteLine($"{nameSecond} is winner with {pointsSecond} points");
                        return;
                    }
                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"{nameFirst} has {pointsFirst} points");
            Console.WriteLine($"{nameSecond} has {pointsSecond} points");
        }
    }
}