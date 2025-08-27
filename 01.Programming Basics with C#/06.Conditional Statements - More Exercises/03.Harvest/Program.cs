namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workes = int.Parse(Console.ReadLine());


            double areaGrapes = x * 0.4;

            double totalGrapesKg = areaGrapes * y;

            double litersWine = totalGrapesKg / 2.5;

            if (litersWine >= z)
            {
                double leftWine = litersWine - z;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(leftWine / workes)} liters per person.");
            }
            else
            {
                double insufficientWine = z - litersWine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(insufficientWine)} liters wine needed.");
            }


        }
    }
}