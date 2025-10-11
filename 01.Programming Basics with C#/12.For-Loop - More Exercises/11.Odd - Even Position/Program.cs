namespace _11.Odd___Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // четем колко числа ще има

            double oddSum = 0;
            double evenSum = 0;

            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)  // броим от 1, защото позициите започват от 1
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0) // четна позиция
                {
                    evenSum += num;

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else // нечетна позиция
                {
                    oddSum += num;

                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (n == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (n == 0 || n == 1)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
    }
