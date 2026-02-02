namespace _04.Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() {1,1,1,1,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 };
            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Count());
            //Console.WriteLine(string.Join(" ", numbers.Select(x => x * x)));
            //Console.WriteLine(string.Join(" ", numbers.Distinct()));

            string[] words = Console.ReadLine()
                            .Split()
                            .Where(x => x.Length % 2 == 0)
                            .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}
