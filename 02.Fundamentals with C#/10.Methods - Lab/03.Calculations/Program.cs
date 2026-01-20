namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            if (input == "add")
            {
                Add(a, b);
            }
            else if (input == "multiply")
            {
                Multiply(a, b);
            }
            else if (input == "subtract") 
            {
                Subtract(a, b);
            }
            else
            {
                Divide(a, b);
            }
        }
        static void Add(int a, int b) 
        {
            Console.WriteLine($"{a+b}");
        }

        static void Multiply(int a, int b) 
        {
            Console.WriteLine($"{a * b}");

        }
        
        static void Subtract(int a, int b)
        {
            Console.WriteLine($"{a - b}");
        }

        static void Divide(int a, int b) 
        {
            Console.WriteLine($"{a / b}");
        }
    }
}
