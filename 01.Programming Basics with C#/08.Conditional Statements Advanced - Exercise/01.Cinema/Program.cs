namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int columns = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            double income = 0;

            int totalTickets = columns * rows;

            if (projectionType == "Premiere")
            {
                income = totalTickets * 12.00; 
            }
            else if (projectionType == "Normal")
            {
                income = totalTickets * 7.5;
            }
            else
            {
                income = totalTickets * 5.00;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}