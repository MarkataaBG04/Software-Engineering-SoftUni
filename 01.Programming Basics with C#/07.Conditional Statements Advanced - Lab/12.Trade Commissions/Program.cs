namespace _12.Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesQuantity = double.Parse(Console.ReadLine());

            double commision = 0;
            bool isValid = true;

            if (city == "Sofia")
            {
                if (0 <= salesQuantity && salesQuantity <= 500)
                {
                    commision = salesQuantity * 0.05;
                }
                else if (500 <= salesQuantity && salesQuantity <= 1000)
                {
                    commision = salesQuantity * 0.07;
                }
                else if (1000 < salesQuantity && salesQuantity <= 10000)
                {
                    commision = salesQuantity * 0.08;
                }
                else if (salesQuantity > 10000)
                {
                    commision = salesQuantity * 0.12;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= salesQuantity && salesQuantity <= 500)
                {
                    commision = salesQuantity * 0.045;
                }
                else if (500 <= salesQuantity && salesQuantity <= 1000)
                {
                    commision = salesQuantity * 0.075;
                }
                else if (1000 < salesQuantity && salesQuantity <= 10000)
                {
                    commision = salesQuantity * 0.10;
                }
                else if (salesQuantity > 10000)
                {
                    commision = salesQuantity * 0.13;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= salesQuantity && salesQuantity <= 500)
                {
                    commision = salesQuantity * 0.055;
                }
                else if (500 <= salesQuantity && salesQuantity <= 1000)
                {
                    commision = salesQuantity * 0.08;
                }
                else if (1000 < salesQuantity && salesQuantity <= 10000)
                {
                    commision = salesQuantity * 0.12;
                }
                else if (salesQuantity > 10000)
                {
                    commision = salesQuantity * 0.145;
                }
                else
                {
                    isValid = false;
                }
            }
            else 
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"{commision:f2}");
            }
            else
            {
                Console.WriteLine($"error");
            }
        }
    }
}