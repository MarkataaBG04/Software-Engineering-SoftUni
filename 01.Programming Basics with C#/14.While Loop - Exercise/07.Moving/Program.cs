namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int apartamentSize = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxes = int.Parse(command);

                apartamentSize -= boxes;

                if (apartamentSize <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(apartamentSize)} Cubic meters more.");
                    return;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"{apartamentSize} Cubic meters left.");
        }
    }
}