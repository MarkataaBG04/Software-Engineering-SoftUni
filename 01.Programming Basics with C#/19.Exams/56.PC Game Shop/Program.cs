namespace _56.PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());

            int countHearthstone = 0;
            int countFortnite = 0;
            int countOverwatch = 0;
            int countOthers = 0;

            for (int i = 1; i <= gamesCount; i++) 
            {
                string gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    countHearthstone++;
                }
                else if (gameName == "Fornite")
                {
                    countFortnite++;
                }
                else if (gameName == "Overwatch")
                {
                    countOverwatch++;
                }
                else 
                {
                    countOthers++;
                }
            }

            Console.WriteLine($"Hearthstone - {(double)countHearthstone/gamesCount * 100:f2}%");
            Console.WriteLine($"Fornite - {(double)countFortnite/gamesCount * 100:f2}%");
            Console.WriteLine($"Overwatch - {(double)countOverwatch/gamesCount*100:f2}%");
            Console.WriteLine($"Others - {(double)countOthers/gamesCount*100:f2}%");
        }
    }
}
