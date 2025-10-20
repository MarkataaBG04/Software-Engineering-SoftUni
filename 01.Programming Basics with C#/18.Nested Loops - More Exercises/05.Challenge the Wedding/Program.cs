namespace _05.Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int manCount = int.Parse(Console.ReadLine());
            int womanCount = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());


            int totalCouples = 0;

            for (int i = 1; i <= manCount; i++)
            {
                for (int j = 1; j <= womanCount; j++)
                {

                    if (tables == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"({i} <-> {j}) ");
                        tables--;
                    }

                }
            }
        }
    }
}