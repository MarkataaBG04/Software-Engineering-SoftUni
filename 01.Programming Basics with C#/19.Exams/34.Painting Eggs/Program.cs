namespace _34.Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string colour = Console.ReadLine();
            int countPartidi = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (size == "Large")
            {
                if (colour == "Red")
                {
                    totalSum = countPartidi * 16;
                }
                else if (colour == "Green")
                {
                    totalSum = countPartidi * 12;
                }
                else if (colour == "Yellow")
                {
                    totalSum = countPartidi * 9;
                }
            }
            else if (size == "Medium")
            {
                if (colour == "Red")
                {
                    totalSum = countPartidi * 13;
                }
                else if (colour == "Green")
                {
                    totalSum = countPartidi * 9;
                }
                else if (colour == "Yellow")
                {
                    totalSum = countPartidi * 7;
                }
            }
            else if (size == "Small")
            {
                if(colour == "Red")
                {
                    totalSum = countPartidi * 9;
                }
                else if (colour == "Green")
                {
                    totalSum = countPartidi * 8;
                }
                else if (colour == "Yellow")
                {
                    totalSum = countPartidi * 5;
                }
            }

            totalSum -= totalSum * 0.35;

            Console.WriteLine($"{totalSum:f2} leva.");
        }
    }
}
