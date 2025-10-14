namespace _02.Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNeeded = int.Parse(Console.ReadLine());

            int cashCounter = 0;
            int cardCounter = 0;

            double cashMoney = 0;
            double cardMoney = 0;

            string command = Console.ReadLine();

            bool isCash = true;

            int totalSum = 0;

            while (command != "End")
            {
                int price = int.Parse(command);

               
                if (isCash)
                {
                    isCash = false;
                    if (price > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        totalSum += price;
                        cashCounter++;
                        cashMoney += price;
                        
                    }
                }
                else
                {
                    isCash = true;
                    if (price < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        totalSum += price;
                        cardCounter++;
                        cardMoney += price;
                        
                    }
                }

                if (totalSum >= sumNeeded)
                {
                    Console.WriteLine($"Average CS: {cashMoney / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {cardMoney / cardCounter:f2}");
                    return;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Failed to collect required money for charity.");
        }
    }
}