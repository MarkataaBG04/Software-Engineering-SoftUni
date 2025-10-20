using System;

namespace _08.Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int ones = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                for (int k = 1; k <= tens; k++)
                {
                    for (int j = 1; j <= ones; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            if (k >= 2 && k <= 7)
                            {
                                // Прости числа между 2 и 7 са 2, 3, 5 и 7
                                if (k == 2 || k == 3 || k == 5 || k == 7)
                                {
                                    Console.WriteLine($"{i} {k} {j}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
