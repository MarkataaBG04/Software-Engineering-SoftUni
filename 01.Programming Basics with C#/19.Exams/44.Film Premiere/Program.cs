namespace _44.Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string menuOption = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());


            double price = 0;

            if (movieName == "John Wick")
            {
                if (menuOption == "Drink")
                {
                    price = ticketCount * 12;
                }
                else if (menuOption == "Popcorn")
                {
                    price = ticketCount * 15;
                }
                else if (menuOption == "Menu")
                {
                    price = ticketCount * 19;
                }
            }
            else if (movieName == "Star Wars")
            {
                if (menuOption == "Drink")
                {
                    price = ticketCount * 18;
                }
                else if (menuOption == "Popcorn")
                {
                    price = ticketCount * 25;
                }
                else if (menuOption == "Menu")
                {
                    price = ticketCount * 30;
                }

                if (ticketCount >= 4)
                {
                    price = price * 0.70;
                }
            }
            else if (movieName == "Jumanji")
            {
                if (menuOption == "Drink")
                {
                    price = ticketCount * 9;
                }
                else if (menuOption == "Popcorn")
                {
                    price = ticketCount * 11;
                }
                else if (menuOption == "Menu")
                {
                    price = ticketCount * 14;
                }

                if (ticketCount == 2)
                {
                    price = price * 0.85;
                }
            }

            Console.WriteLine($"Your bill is {price:f2} leva.");

        }
    }
}
