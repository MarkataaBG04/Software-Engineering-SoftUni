namespace _05.Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                int currentNum = i;
                while (currentNum > 0)
                {
                    int digit = currentNum % 10;
                    currentNum /= 10;


                    if (digit == 0 || number % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}