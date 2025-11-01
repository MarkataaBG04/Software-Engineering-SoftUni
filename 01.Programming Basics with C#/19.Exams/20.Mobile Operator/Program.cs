namespace _20.Mobile_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internetCheck = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;

            if (contractPeriod == "one")
            {
                if (contractType == "Small")
                {
                    price = 9.98;
                }
                else if (contractType == "Middle")
                {
                    price = 18.99;
                }
                else if (contractType == "Large")
                {
                    price = 25.98;
                }
                else if (contractType == "ExtraLarge")
                {
                    price =35.99;
                }
            }
            else if (contractPeriod == "two")
            {
                if (contractType == "Small")
                {
                    price =8.58;
                }
                else if (contractType == "Middle")
                {
                    price =17.09;
                }
                else if (contractType == "Large")
                {
                    price =23.59;
                }
                else if (contractType == "ExtraLarge")
                {
                    price =31.79;
                }
            }


            if (internetCheck == "yes")
            {
                if (price <= 10)
                {
                    price = (price + 5.50) * months;
                }
                else if (price <= 30)
                {
                    price = (price + 4.35) * months;
                }
                else if (price > 30)
                {
                    price = (price +3.85) * months;
                }
            }
            else
            {
                price = price * months;
            }

            if (contractPeriod == "two")
            {
                price = price - (price * 0.0375);
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}