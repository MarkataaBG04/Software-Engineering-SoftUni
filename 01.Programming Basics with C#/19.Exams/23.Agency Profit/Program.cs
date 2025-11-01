namespace _23.Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();

            int adultsTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double priceTicketAdult = double.Parse(Console.ReadLine());
            double taxService = double.Parse(Console.ReadLine());

            double price = (adultsTickets * priceTicketAdult) + (kidTickets * (priceTicketAdult - (priceTicketAdult * 0.70))) + (taxService * (kidTickets + adultsTickets));

            price = price * 0.20;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {price:f2} lv.");
        }
    }
}