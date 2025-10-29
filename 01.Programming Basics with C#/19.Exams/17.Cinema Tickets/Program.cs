namespace _17.Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTickets = 0;

            string movieName = Console.ReadLine();

            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    soldTickets++;
                    totalTickets++;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    if (soldTickets >= freeSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                double percentFull = (double)soldTickets / freeSeats * 100;
                Console.WriteLine($"{movieName} - {percentFull:f2}% full.");

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}