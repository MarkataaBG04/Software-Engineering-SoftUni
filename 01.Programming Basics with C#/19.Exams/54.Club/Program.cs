namespace _54.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double clubWantedMomey = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            double totalSum = 0;



            while (command != "Party!") 
            {
                int countCoctails = int.Parse(Console.ReadLine());

                double currentBill = 0;

                int priceForCoctail = command.Length;

                currentBill = priceForCoctail * countCoctails;

                if (currentBill % 2 != 0)
                {
                    currentBill -= currentBill * 0.25;
                }

                totalSum += currentBill;

                if (clubWantedMomey <= totalSum)
                {
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {totalSum:f2} leva.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"We need {clubWantedMomey - totalSum:f2} leva more.");
            Console.WriteLine($"Club income - {totalSum:f2} leva.");
        }
    }
}
