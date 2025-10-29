namespace _13.Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rentHall = int.Parse(Console.ReadLine());

            double statues = rentHall -  (rentHall * 0.30);

            double ceturing = statues - (statues * 0.15);

            double sound = ceturing / 2;

            double total = rentHall + statues + ceturing + sound;

            Console.WriteLine($"{total:F2}");
        }
    }
}