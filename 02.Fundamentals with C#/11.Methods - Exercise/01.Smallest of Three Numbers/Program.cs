
namespace _01.Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintSmallestNum(a, b, c);
        }

        static void PrintSmallestNum(int first, int second, int third)
        {
            if (first <= second && first <= third)
            {
                Console.WriteLine(first);
            }
            else if (second <= first && second <= third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }
        }
    }
}
