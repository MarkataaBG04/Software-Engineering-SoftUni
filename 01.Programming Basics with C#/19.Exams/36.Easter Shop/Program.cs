namespace _36.Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCountEggs = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int soldCount = 0;

            while (command != "Close")
            {
                int num = int.Parse(Console.ReadLine());

                if (command == "Fill")
                {
                    startCountEggs += num;
                }
                else if (command == "Buy")
                {
                    if (num > startCountEggs)
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startCountEggs}.");
                        return;
                    }
                    else
                    {
                        startCountEggs -= num;
                        soldCount += num;
                    }
                }
                    command = Console.ReadLine();
            }

            Console.WriteLine($"Store is closed!");
            Console.WriteLine($"{soldCount} eggs sold.");
        }
    }
}
