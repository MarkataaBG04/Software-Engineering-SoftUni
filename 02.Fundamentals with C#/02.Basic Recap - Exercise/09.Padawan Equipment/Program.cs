namespace _09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lighsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double percent = (double)studentsCount * 10 / 100;

            double allSabers = studentsCount + Math.Ceiling(percent);
            double sabers = lighsabersPrice * allSabers;

            double robes = robesPrice * studentsCount;

            double beltDiscount = studentsCount - Math.Ceiling((double)(studentsCount / 6));
            double belts = beltsPrice * beltDiscount;

            double totalSum = sabers + robes + belts;





            if (money >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - money:f2}lv more.");
            }

        }
    }
}
