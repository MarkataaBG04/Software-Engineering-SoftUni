using System.Numerics;

namespace _35.Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "End") 
            {
                if (command == "one")
                {
                    secondPlayerEggs--;
                    if (secondPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                        return;
                    }
                }
                else
                {
                    firstPlayerEggs--;
                    if (firstPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                        return;
                    }
                }


                    command = Console.ReadLine();
            }

            Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
            Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
        }
    }
}
