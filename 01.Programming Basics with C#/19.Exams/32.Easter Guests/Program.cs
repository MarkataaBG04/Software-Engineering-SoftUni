namespace _32.Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double neededKozunaks = Math.Ceiling(guests / 3.0);
            int eggsNeeded = guests * 2;

            double totalSum = neededKozunaks * 4 + eggsNeeded * 0.45;

            if (totalSum <= budjet)
            {
                Console.WriteLine($"Lyubo bought {neededKozunaks} Easter bread and {eggsNeeded} eggs.");
                Console.WriteLine($"He has {budjet-totalSum:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalSum - budjet:f2} lv. more.");
            }
        }
    }
}
