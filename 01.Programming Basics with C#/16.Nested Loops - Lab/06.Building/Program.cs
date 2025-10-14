namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                for (int j = 1; j <= roomsPerFloor; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{floors}{j-1} ");
                    }

                    if (i % 2 == 0 && i != floors)
                    {
                        Console.Write($"O{i}{j - 1} ");
                    }
                    else if(i % 2 == 1 && i != floors)
                    {
                        Console.Write($"A{i}{j - 1} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
 
    }
}