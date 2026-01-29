namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToList();

            List<char> text = Console.ReadLine().ToList();

            string message = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                int index = 0;
                int sum = 0;
                while (currentNum > 0) 
                {
                    int currentDigit = currentNum % 10;
                    sum += currentDigit;
                    currentNum /= 10;
                }
                index = sum;

                index %= text.Count;

                Console.Write(text[index]);
                text.RemoveAt(index);
            }
        }
    }
}
