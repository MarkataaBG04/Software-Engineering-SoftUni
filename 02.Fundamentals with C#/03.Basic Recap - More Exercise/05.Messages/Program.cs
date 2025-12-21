namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = "";


            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int mainDigit = number % 10;
                int digitsCount = 0;
                while (number > 0)
                {
                    number = number / 10;
                    digitsCount++;
                }

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + digitsCount - 1;

                char[] letters = {
                                        'a','b','c',    // 0 1 2
                                        'd','e','f',    // 3 4 5
                                        'g','h','i',    // 6 7 8
                                        'j','k','l',    // 9 10 11
                                        'm','n','o',    // 12 13 14
                                        'p','q','r','s',// 15 16 17 18
                                        't','u','v',    // 19 20 21
                                        'w','x','y','z' // 22 23 24 25
                                    };

                // Пример: number = индекс (0-25)
                if (letterIndex >= 0 && letterIndex < letters.Length)
                {
                    message += letters[letterIndex];
                }

                if (mainDigit == 0)
                {
                    message += " ";
                }
            }
            Console.WriteLine(message);
        }
    }
}

