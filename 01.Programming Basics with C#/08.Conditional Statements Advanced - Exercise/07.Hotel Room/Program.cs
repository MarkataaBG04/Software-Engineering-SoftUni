namespace _07.Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleeps = int.Parse(Console.ReadLine());

            double apartamentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = sleeps * 50;
                apartamentPrice = sleeps * 65;
                if (sleeps > 14)
                {
                    studioPrice = studioPrice * 0.70;
                }
                else if (sleeps > 7)
                {
                    studioPrice = studioPrice * 0.95;
                }
                
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = sleeps * 75.20;
                apartamentPrice = sleeps * 68.70;
                if (sleeps > 14)
                {
                    studioPrice = studioPrice * 0.80;
                }
            }
            else if(month == "July" || month == "August")
            {
                studioPrice = sleeps * 76;
                apartamentPrice = sleeps * 77;
            }

            if (sleeps > 14)
            {
                apartamentPrice = apartamentPrice * 0.90;
            }


            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}