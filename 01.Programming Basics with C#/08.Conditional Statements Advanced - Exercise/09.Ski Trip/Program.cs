namespace _09.Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sleeps = int.Parse(Console.ReadLine()) - 1;
            string roomKind = Console.ReadLine();
            string review = Console.ReadLine();

            double price = 0;

            if (roomKind == "room for one person")
            {
                price = sleeps * 18.00;
            }
            else if (roomKind == "apartment")
            {
                price = sleeps * 25.00;
                if (sleeps < 10)
                {
                    price = price * 0.70;
                }
                else if (sleeps >= 10 && sleeps <= 15)
                {
                    price = price * 0.75;
                }
                else if (sleeps > 15)
                {
                    price = price * 0.50;
                }
            }
            else if (roomKind == "president apartment")
            {
                price = sleeps * 35.00;
                if (sleeps < 10)
                {
                    price = price * 0.90;
                }
                else if (sleeps >= 10 && sleeps <= 15)
                {
                    price = price * 0.85;
                }
                else if (sleeps > 15)
                {
                    price = price * 0.80;
                }
            }
        }
    }
}