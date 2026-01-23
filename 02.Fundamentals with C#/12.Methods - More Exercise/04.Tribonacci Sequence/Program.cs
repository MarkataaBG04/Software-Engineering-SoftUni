
namespace _04.Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(num);
        }

        private static void PrintTribonacciSequence(int n)
        {
            int a = 1;
            int b = 1;
            int c = 2;

            if (n >= 1) Console.Write(a + " ");
            if (n >= 2) Console.Write(b + " ");
            if (n >= 3) Console.Write(c + " ");

            for (int i = 4; i <= n; i++)
            {
                int next = a + b + c; // следващото число = сбор на последните 3
                Console.Write(next + " ");

                // преместим числата напред
                a = b;
                b = c;
                c = next;
            }
        }
    }
}
