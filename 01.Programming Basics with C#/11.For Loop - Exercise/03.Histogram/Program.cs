namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1Count++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2Count++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3Count++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4Count++;
                }
                else if (num >= 800)
                {
                    p5Count++;
                }
            }
            Console.WriteLine($"{(double)p1Count / n * 100:f2}%");
            Console.WriteLine($"{(double)p2Count / n * 100:f2}%");
            Console.WriteLine($"{(double)p3Count / n * 100:f2}%");
            Console.WriteLine($"{(double)p4Count / n * 100:f2}%");
            Console.WriteLine($"{(double)p5Count / n * 100:f2}%");
        }
    }
}