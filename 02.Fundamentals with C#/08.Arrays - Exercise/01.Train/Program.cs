namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] peopleInWagons = new int[wagons];

            for (int i = 0; i < wagons; i++) 
            {
               peopleInWagons[i] = int.Parse(Console.ReadLine());
               sum += peopleInWagons[i];
            }
            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(sum);
            
        }
    }
}
