namespace _25.Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string deliveryCheck = Console.ReadLine();

            double price = 0;

            if (joineryCount < 10)
            {
                Console.WriteLine($"Invalid order");
                return;
            }

            if (joineryType == "90X130")
            {
                price = joineryCount * 110;
                if (joineryCount > 60)
                {
                    price = price - (price * 0.08);
                }
                else if (joineryCount > 30)
                {
                    price = price - (price * 0.05);
                }
                
            }
            else if (joineryType == "100X150")
            {
                price = joineryCount * 140;
                if (joineryCount > 80)
                {
                    price = price - (price * 0.10);
                }
                else if (joineryCount > 40)
                {
                    price = price - (price * 0.06);
                }
                
            }
            else if (joineryType == "130X180")
            {
                price = joineryCount * 190;
                if (joineryCount > 50)
                {
                    price = price - (price * 0.12);
                }
                else if (joineryCount > 20)
                {
                    price = price - (price * 0.07);
                }
                
            }
            else if (joineryType == "200X300")
            {
                price = joineryCount * 250;
                if (joineryCount > 50)
                {
                    price = price - (price * 0.14);
                }
                else if (joineryCount > 25)
                {
                    price = price - (price * 0.09);
                }
                
            }

            if (deliveryCheck == "With delivery")
            {
                price += 60;
            }


            if (joineryCount > 99)
            {
                price = price - (price * 0.04);
            }


            Console.WriteLine($"{price:f2} BGN");
        }
    }
}