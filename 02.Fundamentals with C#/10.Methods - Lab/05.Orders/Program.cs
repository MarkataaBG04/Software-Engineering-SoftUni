using System.Runtime.CompilerServices;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            

            Order(product, quantity);
        }

        static void Order(string product, double quantity) 
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2.00:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
