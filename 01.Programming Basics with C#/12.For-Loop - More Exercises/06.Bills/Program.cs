namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricityTotal = 0;
            double water = 20;
            double internet = 15; 
            double others = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());
                electricityTotal += electricityPerMonth;

                others = others + (electricityPerMonth + water + internet) * 1.20;
            }

            double average = (electricityTotal + others + (water * months) + (internet * months)) / months;
            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {water * months:f2} lv");
            Console.WriteLine($"Internet: {internet * months:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}