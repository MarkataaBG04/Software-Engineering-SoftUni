namespace _01.Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int pinCode = 0;

            for (int i = 1; i <= firstNum; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= secondNum; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int k = 1; k <= thirdNum; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                                
                            }
                        }
                    }
                }
            }

        }
    }
}