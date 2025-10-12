namespace _05.Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double balance = 0;

         

            while (command != "NoMoreMoney")
            {
                double sum = double.Parse(command);
                if (sum < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                else
                {
                    balance += sum;
                    Console.WriteLine($"Increase: {sum:f2}");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}