namespace _06.World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matchCategory = Console.ReadLine();
            string ticketCateory = Console.ReadLine();
            int totalTickets =  int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double totalPrice = 0;


            if (matchCategory == "Quarter final")
            {
                if (ticketCateory == "Standard")
                {
                    totalPrice = totalTickets * 55.50;
                }
                else if (ticketCateory == "Premium")
                {
                    totalPrice = totalTickets * 105.20;
                }
                else if (ticketCateory == "VIP")
                {
                    totalPrice = totalTickets * 118.90;
                }
            }
            else if (matchCategory == "Semi final")
            {
                if (ticketCateory == "Standard")
                {
                    totalPrice = totalTickets * 75.88;
                }
                else if (ticketCateory == "Premium")
                {
                    totalPrice = totalTickets * 125.22;
                }
                else if (ticketCateory == "VIP")
                {
                    totalPrice = totalTickets * 300.40;
                }
            }
            else if (matchCategory == "Final")
            {
                if (ticketCateory == "Standard")
                {
                    totalPrice = totalTickets * 110.10;
                }
                else if (ticketCateory == "Premium")
                {
                    totalPrice = totalTickets * 160.66;
                }
                else if (ticketCateory == "VIP")
                {
                    totalPrice = totalTickets * 400;
                }
            }


            if (totalPrice > 4000)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }
            else if (totalPrice > 2500)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }

            if (totalPrice <= 4000 && picture == 'Y')
            {
                totalPrice += 40 * totalTickets;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}