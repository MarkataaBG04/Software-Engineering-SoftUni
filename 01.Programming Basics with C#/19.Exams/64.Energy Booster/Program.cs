namespace _64.Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeSet = Console.ReadLine();
            int setOrderedCount = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (sizeSet == "small")
            {
                if (fruit == "Watermelon")
                {
                    totalSum = 2 * setOrderedCount * 56;
                }
                else if (fruit == "Mango")
                {
                    totalSum = 2 * setOrderedCount * 36.66;
                }
                else if (fruit == "Pineapple")
                {
                    totalSum = 2 * setOrderedCount * 42.10;
                }
                else if (fruit == "Raspberry")
                {
                    totalSum = 2 * setOrderedCount * 20;
                }
            }
            else if (sizeSet == "big")
            {
                if (fruit == "Watermelon")
                {
                    totalSum = 5 * setOrderedCount * 28.70;
                }
                else if (fruit == "Mango")
                {
                    totalSum = 5* setOrderedCount * 19.60;
                }
                else if (fruit == "Pineapple")
                {
                    totalSum = 5 * setOrderedCount * 24.8;
                }
                else if (fruit == "Raspberry")
                {
                    totalSum = 5 * setOrderedCount * 15.20;
                }
            }

            if (totalSum >= 400 && totalSum <= 1000)
            {
                totalSum -= totalSum * 0.15;
            }
            else if (totalSum > 1000)
            {
                totalSum /= 2;
            }

            Console.WriteLine($"{totalSum:f2} lv.");

        }
    }
}
