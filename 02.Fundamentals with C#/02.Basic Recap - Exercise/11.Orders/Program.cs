namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 1; i <= orders; i++)
            {
                double sum = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                 sum = ((days * capsulesCount) * pricePerCapsule);
                 totalSum += sum; 

                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
