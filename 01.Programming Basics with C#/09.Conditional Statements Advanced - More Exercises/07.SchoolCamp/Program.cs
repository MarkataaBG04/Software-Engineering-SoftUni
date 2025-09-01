namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int countStudents = int.Parse(Console.ReadLine());
            int sleeps = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            if (group == "girls" || group == "boys")
            {
                if (season == "Winter")
                {
                    price = (sleeps * 9.60) * countStudents;
                }
                else if (season == "Spring")
                {
                    price = (sleeps * 7.20) * countStudents;
                }
                else
                {
                    price = (sleeps * 15) * countStudents;
                }
            }
            else if (group == "mixed")
            {
                if (season == "Winter")
                {
                    price = (sleeps * 10) * countStudents;
                }
                else if (season == "Spring")
                {
                    price = (sleeps * 9.50) * countStudents;
                }
                else
                {
                    price = (sleeps * 20) * countStudents;
                }
            }


            if (countStudents >= 50)
            {
                price = price - (price * 0.50);
            }
            else if (countStudents >= 20 && countStudents < 50)
            {
                price = price - (price * 0.15);
            }
            else if (countStudents >= 10 && countStudents < 20)
            {
                price = price - (price * 0.05);
            }


            if (group == "girls")
            {
                if (season == "Winter")
                {
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    sport = "Volleyball";
                }
            }
            else if (group == "boys")
            {
                if (season == "Winter")
                {
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    sport = "Football";
                }
            }
            else if (group == "mixed")
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {price:f2} lv.");

        }
    }
}