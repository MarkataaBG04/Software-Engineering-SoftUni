namespace _09.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCount = 0;
            int totalAmountSpice = 0;


            if (startingYield < 100)
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalAmountSpice);
            }
            else
            {
                while (startingYield >= 100)
                {
                    daysCount++;
                    totalAmountSpice += startingYield - 26;
                    startingYield -= 10;
                }
                totalAmountSpice -= 26;
                Console.WriteLine(daysCount);
                Console.WriteLine(totalAmountSpice);
            }

                
        }
    }
}
