namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalPieces = width * length;

            string command = Console.ReadLine(); 

            while (command != "STOP")
            {
                int pieces = int.Parse(command);

                totalPieces -= pieces;

                if (totalPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    return;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
}