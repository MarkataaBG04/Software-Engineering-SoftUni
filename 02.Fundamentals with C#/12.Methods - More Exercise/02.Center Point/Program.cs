namespace _02.Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterPoint(x1, y1, x2, y2);
        }

        private static void CenterPoint(double x1, double y1, double x2, double y2)
        {
            double dist1Sq = x1 * x1 + y1 * y1;
            double dist2Sq = x2 * x2 + y2 * y2;

            if (dist1Sq <= dist2Sq)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
