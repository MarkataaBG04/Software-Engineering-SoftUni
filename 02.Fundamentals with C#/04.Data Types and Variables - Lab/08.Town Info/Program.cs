namespace _08.Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            ushort area = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}
