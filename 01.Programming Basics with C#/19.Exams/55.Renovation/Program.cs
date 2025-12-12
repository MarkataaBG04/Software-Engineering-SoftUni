namespace _55.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentNoPaint = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int totalSurfaceArea = height * width * 4;

            double wallsForPainting = totalSurfaceArea - Math.Ceiling(totalSurfaceArea * (percentNoPaint / 100.0));



            while (command != "Tired!")
            {
                int litersPaint = int.Parse(command);

                wallsForPainting -= litersPaint;

                if (wallsForPainting < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(wallsForPainting)} l paint left!");
                    return;
                }
                else if (wallsForPainting == 0) 
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{wallsForPainting} quadratic m left.");

        }
    }
}
