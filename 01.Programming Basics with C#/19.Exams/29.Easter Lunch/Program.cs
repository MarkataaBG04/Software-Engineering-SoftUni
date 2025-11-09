namespace _29.Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunakCount =  int.Parse(Console.ReadLine());
            int eggsPacksCount =  int.Parse(Console.ReadLine());
            int kgCokies =  int.Parse(Console.ReadLine());

            double totalPrice = (kozunakCount * 3.20) + (eggsPacksCount * 4.35) + (kgCokies * 5.40) + (eggsPacksCount * 12 * 0.15);

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}