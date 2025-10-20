namespace _11.HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double price = 0;
            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                price = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0 )
                    {
                        price += 2.5;
                  
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        price += 1.25;
                        
                    }
                    else
                    {
                        price += 1;
                        
                    }

                }
                total += price;
                Console.WriteLine($"Day: {i} - {price:f2} leva");
            }

            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}