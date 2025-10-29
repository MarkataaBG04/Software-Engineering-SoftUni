namespace _14.Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            string category = Console.ReadLine();

            int ticketsBought = int.Parse(Console.ReadLine());

            double price = 0;

            if (category == "normal")
            {
                if (movieName == "A Star Is Born")
                {
                    price = ticketsBought * 7.50;
                }
                else if (movieName == "Bohemian Rhapsody")
                {
                    price = ticketsBought * 7.35;
                }
                else if (movieName == "Green Book")
                {
                    price = ticketsBought * 8.15;
                }
                else if (movieName == "The Favourite")
                {
                    price = ticketsBought * 8.75;
                }
            }
            else if (category == "luxury")
            {
                if (movieName == "A Star Is Born")
                {
                    price = ticketsBought * 10.50;
                }
                else if (movieName == "Bohemian Rhapsody")
                {
                    price = ticketsBought * 9.45;
                }
                else if (movieName == "Green Book")
                {
                    price = ticketsBought * 10.25;
                }
                else if (movieName == "The Favourite")
                {
                    price = ticketsBought * 11.55;
                }
            }
            else if (category == "ultra luxury")
            {
                if (movieName == "A Star Is Born")
                {
                    price = ticketsBought * 13.50;
                }
                else if (movieName == "Bohemian Rhapsody")
                {
                    price = ticketsBought * 12.75;
                }
                else if (movieName == "Green Book")
                {
                    price = ticketsBought * 13.25;
                }
                else if (movieName == "The Favourite")
                {
                    price = ticketsBought * 13.95;
                }
            }

            Console.WriteLine($"{movieName} -> {price:F2} lv.");

        }
    }
}