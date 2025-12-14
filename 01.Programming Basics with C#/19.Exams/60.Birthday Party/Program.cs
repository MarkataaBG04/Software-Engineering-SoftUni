namespace _60.Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cake = hallRent * 0.20;
            double drinks = cake - (cake * 0.45);
            double animator = hallRent / 3;


            double totalSum = hallRent + cake + drinks + animator;

            Console.WriteLine($"{totalSum}");
        }
    }
}
