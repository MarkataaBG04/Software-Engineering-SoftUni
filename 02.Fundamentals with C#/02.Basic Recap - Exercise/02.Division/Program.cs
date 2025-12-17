namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int devision = 0;

            if (number % 10 == 0)
            {
                devision = 10;
            }
            else if (number % 7 == 0)
            {
                devision = 7;
            }
            else if (number % 6 == 0)
            {
                devision = 6;
            }
            else if (number % 3 == 0)
            {
                devision = 3;
            }
            else if (number % 2 == 0)
            {
                devision = 2;
            }
            else 
            {
                Console.WriteLine($"Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {devision}");
        }
    }
}
