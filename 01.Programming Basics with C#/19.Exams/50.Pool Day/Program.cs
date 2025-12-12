namespace _50.Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double taxEntrance = double.Parse(Console.ReadLine());
            double deckChair = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());


            double totalSum = (peopleCount * taxEntrance) + (Math.Ceiling(peopleCount * 0.75) * deckChair) + (Math.Ceiling(peopleCount * 0.50 ) * umbrella);
            Console.WriteLine($"{totalSum:f2} lv.");


        }
    }
}
