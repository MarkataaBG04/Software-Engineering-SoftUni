namespace _04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double wachingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double recieveMoney = 0;
            double toyCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    recieveMoney += 10;
                    savedMoney += recieveMoney - 1;
                }
                else
                {
                    toyCount++;
                }
                
            }

            
            savedMoney = savedMoney + (toyPrice * toyCount);

            if (savedMoney >= wachingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - wachingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {wachingMachinePrice - savedMoney:f2}");
            }


        }
    }
}