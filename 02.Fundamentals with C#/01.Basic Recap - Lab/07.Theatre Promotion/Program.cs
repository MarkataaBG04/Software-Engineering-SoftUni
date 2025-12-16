namespace _07.Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int sum = 0;

            if (day == "Weekday") 
            {
                if (0 <= age && age <= 18)
                {
                    sum = 12;
                }
                else if (18 < age && age <= 64)
                {
                    sum = 18;
                }
                else if (64 < age && age <= 122)
                {
                    sum = 12;
                }
                else
                {
                    Console.WriteLine($"Error!");
                    return;
                }
            }
            else if (day == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    sum = 15;
                }
                else if (18 < age && age <= 64)
                {
                    sum = 20;
                }
                else if (64 < age && age <= 122)
                {
                    sum = 15;
                }
                else
                {
                    Console.WriteLine($"Error!");
                    return;
                }
            }
            else if (day == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    sum = 5;
                }
                else if (18 < age && age <= 64)
                {
                    sum = 12;
                }
                else if (64 < age && age <= 122)
                {
                    sum = 10;
                }
                else
                {
                    Console.WriteLine($"Error!");
                    return;
                }
            }

            Console.WriteLine($"{sum}$");
        }
    }
}
