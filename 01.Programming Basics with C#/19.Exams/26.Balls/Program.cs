namespace _26.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nBalls = int.Parse(Console.ReadLine());

            int points = 0;

            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int blackCount = 0;
            int otherColor = 0;


            for (int i = 1; i <= nBalls; i++)
            {
                string colours = Console.ReadLine();

                if (colours == "red")
                {
                    points += 5;
                    redCount++;
                }
                else if (colours == "orange")
                {
                    points += 10;
                    orangeCount++;
                }
                else if (colours == "yellow")
                {
                    points += 15;
                    yellowCount++;
                }
                else if (colours == "white")
                {
                    points += 20;
                    whiteCount++;
                }
                else if (colours == "black")
                {
                    points /= 2;
                    blackCount++;
                }
                else
                {
                    otherColor++;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherColor}");
            Console.WriteLine($"Divides from black balls: {blackCount}");

        }
    }
}