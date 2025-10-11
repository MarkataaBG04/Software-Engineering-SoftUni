namespace _07.Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int v = 0;
            int g = 0;
           

            for (int i = 1; i <= totalFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    a++;
                }
                else if (sector == "B")
                {
                    b++;
                }
                else if (sector == "V")
                {
                    v++;
                }
                else if (sector == "G")
                {
                    g++;
                }
            }

            Console.WriteLine($"{(double)a/totalFans * 100:F2}%");
            Console.WriteLine($"{(double)b / totalFans * 100:F2}%");
            Console.WriteLine($"{(double)v / totalFans * 100:F2}%");
            Console.WriteLine($"{(double)g / totalFans * 100:F2}%");
            Console.WriteLine($"{(double)totalFans/stadiumCapacity *100:F2}%");
        }
    }
}