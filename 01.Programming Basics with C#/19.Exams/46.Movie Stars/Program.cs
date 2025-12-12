namespace _46.Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "ACTION")
            {
                int letters = command.Length;

                if (letters > 15) 
                {
                    budjet = budjet - (budjet * 0.20);
                    if (budjet < 0)
                    {
                        Console.WriteLine($"We need {Math.Abs(budjet):f2} leva for our actors.");
                        return;
                    }
                }
                else
                {
                    double salary = double.Parse(Console.ReadLine());
                    budjet -= salary;
                    if (budjet < 0)
                    {
                        Console.WriteLine($"We need {Math.Abs(budjet):f2} leva for our actors.");
                        return;
                    }
                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"We are left with {budjet:f2} leva.");

        }
    }
}
