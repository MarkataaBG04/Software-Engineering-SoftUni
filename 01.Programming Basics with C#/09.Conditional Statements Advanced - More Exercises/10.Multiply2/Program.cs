namespace _10.Multiply2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double result = 0;

            while (number >= 0)
            {
                result = number * 2;
                Console.WriteLine($"Result: {result:f2}");
                number = double.Parse(Console.ReadLine());
            }

            if (number < 0)
            {
                Console.WriteLine($"Negative number!");
            }
        }
    }
}