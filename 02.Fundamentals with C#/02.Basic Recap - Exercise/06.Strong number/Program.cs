namespace _06.Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberCopy = number;
            int factorialSum = 0;

            //145

            while (numberCopy > 0)
            {
                int digit = numberCopy % 10; //5
                numberCopy = numberCopy / 10; //14

                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }



            if (number != factorialSum)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }

        }
    }
}
