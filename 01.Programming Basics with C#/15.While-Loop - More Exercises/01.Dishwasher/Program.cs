namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergent = int.Parse(Console.ReadLine()) * 750;


            int counter = 1;

            int totalCleanedPlates = 0;

            int totalPotsCleaned = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int dishes = int.Parse(command);

                if (counter % 3 == 0)
                {
                    if (detergent >= dishes * 15)
                    {
                        totalPotsCleaned += dishes;
                        detergent -= dishes * 15;

                    }
                    else
                    {
                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent - dishes * 15)} ml. more necessary!");
                        return;
                    }
                }
                else
                {
                    if (detergent >= dishes * 5)
                    {
                        totalCleanedPlates += dishes;
                        detergent -= dishes * 5;

                    }
                    else
                    {
                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent - dishes * 5)} ml. more necessary!");
                        return;
                    }
                }

                counter++;


                command = Console.ReadLine();
            }

            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{totalCleanedPlates} dishes and {totalPotsCleaned} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergent} ml.");
        } 
    }
}