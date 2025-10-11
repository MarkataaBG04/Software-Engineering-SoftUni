namespace _05.Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double points = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double invalid = 0;

            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

       
                if (number >= 0 && number <= 9)
                {
                    points += number * 0.20;
                    p1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    points += number * 0.30;
                    p2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    points += number * 0.40;
                    p3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    points += 50;
                    p4++;
                }
                else if (number >= 40 && number <=50)
                {
                    points += 100;
                    p5++;
                }
                else if (number > 50 || number < 0)
                {
                    points = points / 2;
                    invalid++;
                }
            }

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {(double)p1 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)p2 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)p3 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)p4 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)p5/moves*100:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalid/moves * 100:f2}%");
        }
    }
}