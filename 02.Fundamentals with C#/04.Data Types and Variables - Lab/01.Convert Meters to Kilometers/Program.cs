namespace _01.Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            double km = (double)distanceMeters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
