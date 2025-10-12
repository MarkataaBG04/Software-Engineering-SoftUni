namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());

            double money = double.Parse(Console.ReadLine());

            int spendCounter = 0;

            int daysCount = 0;

            while (spendCounter != 5)
            {

                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                
                

                if (action == "save")
                {
                    money += sum;
                    daysCount++;
                    spendCounter = 0;
                    if (holidayPrice <= money)
                    {
                        Console.WriteLine($"You saved the money for {daysCount} days.");
                        return;
                    }
                }
                else if (action == "spend")
                {
                    spendCounter++;
                    daysCount++;
                    if (sum > money)
                    {
                        money = 0;
                    }
                    else
                    {
                        money -= sum;
                    }
                    
                }

                if (spendCounter == 5)
                {
                    break;
                }
            }

            Console.WriteLine($"You can't save the money.");
            Console.WriteLine($"{daysCount}");
        }
    }
}