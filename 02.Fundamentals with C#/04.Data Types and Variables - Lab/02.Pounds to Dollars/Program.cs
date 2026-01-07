namespace _02.Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double usd = pounds * 1.31;
            Console.WriteLine($"{usd:F3}");
        }
    }
}
