namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double needMoney = double.Parse(Console.ReadLine());

                double savedMoney = 0;

                while (savedMoney < needMoney)
                {
                    double salaries = double.Parse(Console.ReadLine());
                    savedMoney += salaries;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}