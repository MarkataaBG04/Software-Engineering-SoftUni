namespace _01.Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firstPipe = p1 * hours;
            double secondPipe = p2 * hours;

            double totalWater = firstPipe + secondPipe;

            if (totalWater <= v)
            {
                Console.WriteLine($"The pool is {(totalWater / v) * 100:f2}% full. Pipe 1: {(firstPipe / totalWater) * 100:f2}%. Pipe 2: {(secondPipe / totalWater) * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {totalWater - v:f2} liters.");
            }
        }
    }
}