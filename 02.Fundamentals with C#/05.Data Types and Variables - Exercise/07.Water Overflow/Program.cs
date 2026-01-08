namespace _07.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;

            int n = int.Parse(Console.ReadLine());

            int totalLitersPoured = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (waterTank - liters >= 0)
                {
                    totalLitersPoured += liters;
                    waterTank -= liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine($"{totalLitersPoured}");
        }
    }
}
