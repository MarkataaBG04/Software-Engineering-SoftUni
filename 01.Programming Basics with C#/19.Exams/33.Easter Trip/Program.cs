namespace _33.Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    totalSum = nights * 30;
                }
                else if (dates == "24-27")
                {
                    totalSum = nights * 35;
                }
                else if (dates == "28-31")
                {
                    totalSum = nights * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    totalSum = nights * 28;
                }
                else if (dates == "24-27")
                {
                    totalSum = nights * 32;
                }
                else if (dates == "28-31")
                {
                    totalSum = nights * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    totalSum = nights * 32;
                }
                else if (dates == "24-27")
                {
                    totalSum = nights * 37;
                }
                else if (dates == "28-31")
                {
                    totalSum = nights * 43;
                }
            }


            Console.WriteLine($"Easter trip to {destination} : {totalSum:f2} leva.");

        }
    }
}
