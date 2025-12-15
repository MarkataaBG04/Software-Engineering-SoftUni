namespace _70.Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysTournament = int.Parse(Console.ReadLine());
            double totalMoney = 0;
            
            int wonDays = 0;
            int lostDays = 0;


            for (int i = 1; i <= daysTournament; i++)
            {
            int loseCount = 0;
            int winCount = 0;
            double dayMoney = 0;

                string sport = Console.ReadLine();

                while (sport  != "Finish")
                {
                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        dayMoney += 20;
                        winCount++;
                    }
                    else if (winOrLose == "lose")
                    {
                        loseCount++;
                    }
                        sport = Console.ReadLine();
                }
                if (winCount > loseCount)
                {
                    dayMoney *= 1.10;
                    totalMoney += dayMoney;
                    wonDays++;
                }
                else 
                {
                    lostDays++;
                    totalMoney += dayMoney;
                }

            }

            if (wonDays > lostDays)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
            
        }
    }
}
