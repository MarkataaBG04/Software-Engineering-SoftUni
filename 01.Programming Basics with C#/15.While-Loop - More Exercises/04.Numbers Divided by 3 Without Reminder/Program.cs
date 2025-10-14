namespace _04.Numbers_Divided_by_3_Without_Reminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 0;
            //while (num <= 100)
            //{
            //    if (num % 3 == 0 && num != 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    num += 3;
            //}

            for (int i = 0; i <= 100; i+= 3)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}