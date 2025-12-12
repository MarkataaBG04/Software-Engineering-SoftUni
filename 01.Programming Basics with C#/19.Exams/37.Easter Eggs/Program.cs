namespace _37.Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggCount = int.Parse(Console.ReadLine());

            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            string highEggs = "";
            int largesNum = 0;

            for (int i = 1; i <= eggCount; i++)
            {
                string colour = Console.ReadLine();

                if (colour == "red")
                {
                    redCount++;
                }
                else if (colour == "orange")
                {
                    orangeCount++;
                }
                else if (colour == "blue")
                {
                    blueCount++;
                }
                else if (colour == "green")
                {
                    greenCount++;
                }

            }

            largesNum = redCount;
            highEggs = "red";


            if (orangeCount > largesNum)
            {
                largesNum = orangeCount;
                highEggs = "orange";
            }
            if (blueCount > largesNum)
            {
                largesNum = blueCount;
                highEggs = "blue";
            }
            if (greenCount > largesNum)
            {
                largesNum = greenCount;
                highEggs = "green";
            }


            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {largesNum} -> {highEggs}");
        }
    }
}
