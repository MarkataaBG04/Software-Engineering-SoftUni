namespace _08.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int startingPoints = 301;

            int succssfuulTarget = 0;
            int unsuccssfuulTarget = 0;

            string command = Console.ReadLine();

           while (command != "Retire")
            {
                string field = command;
                int points = int.Parse(Console.ReadLine());

                if (field == "Single")
                {
                    if (points > startingPoints)
                    {
                        unsuccssfuulTarget++;
                    }
                    else
                    {
                        startingPoints -= points;
                        succssfuulTarget++;
                    }
                }
                else if (field == "Double")
                {
                    if (points * 2 > startingPoints)
                    {
                        unsuccssfuulTarget++;
                    }
                    else
                    {
                        startingPoints -= points * 2;
                        succssfuulTarget++;
                    }
                }
                else if (field == "Triple")
                {
                    if (points * 3 > startingPoints)
                    {
                        unsuccssfuulTarget++;
                    }
                    else
                    {
                        startingPoints -= points * 3;
                        succssfuulTarget++;
                    }
                }

                if (startingPoints == 0)
                {
                    Console.WriteLine($"{name} won the leg with {succssfuulTarget} shots.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{name} retired after {unsuccssfuulTarget} unsuccessful shots.");
        }
    }
}