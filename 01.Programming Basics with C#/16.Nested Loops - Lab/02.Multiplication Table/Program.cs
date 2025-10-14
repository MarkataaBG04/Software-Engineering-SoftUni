namespace _02.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int fMultiplier = 1; fMultiplier <= 10; fMultiplier++)
            {
                for (int sMultiplier = 1; sMultiplier <= 10; sMultiplier++)
                {
                    Console.WriteLine($"{fMultiplier} * {sMultiplier} = {fMultiplier * sMultiplier}");
                }
            }
        }
    }
}