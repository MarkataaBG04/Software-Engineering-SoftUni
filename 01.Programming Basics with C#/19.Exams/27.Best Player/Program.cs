namespace _27.Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalsMost = 0;
            string bestFootballer = string.Empty;
            bool hattrick = false;

            string namePlayer = Console.ReadLine();

            while (namePlayer != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > goalsMost)
                {
                    bestFootballer = namePlayer;
                    goalsMost = goals;
                    if (goals >= 3)
                    {
                        hattrick = true;
                    }

                    if (goals >= 10)
                    {
                        break;
                    }
                }


                namePlayer = Console.ReadLine();
            }

            Console.WriteLine($"{bestFootballer} is the best player!");
            if (hattrick)
            {
                Console.WriteLine($"He has scored {goalsMost} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsMost} goals.");
            }
        }
    }
}