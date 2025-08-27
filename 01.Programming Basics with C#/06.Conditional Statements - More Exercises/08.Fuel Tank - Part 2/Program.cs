namespace _08.Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string cardCheck = Console.ReadLine();

            bool hasCard;

            if (cardCheck == "Yes")
            {
                hasCard = true;
            }
            else
            {
                hasCard = false;
            }

            if (fuelType == "Gas")
            {
                double totalPrice = 0;
                if (hasCard == true)
                {
                    totalPrice = liters * (0.93 - 0.08);
                }
                else
                {
                    totalPrice = liters * 0.93;
                }
                if (liters >= 20 && liters <= 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.08);
                }
                else if (liters > 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }

                Console.WriteLine($"{totalPrice:f2} lv.");
            }
            else if (fuelType == "Gasoline")
            {
                double totalPrice = 0;
                if (hasCard == true)
                {
                    totalPrice =  liters * (2.22 - 0.18);
                }
                else
                {
                    totalPrice = liters * 2.22;
                }
                if (liters >= 20 && liters <= 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.08);
                }
                else if (liters > 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }

                Console.WriteLine($"{totalPrice:f2} lv.");
            }
            else
            {
                double totalPrice = 0;
                if (hasCard == true)
                {
                    totalPrice = liters * (2.33 - 0.12);
                }
                else
                {
                    totalPrice = liters * 2.33;
                }
                if (liters >= 20 && liters <= 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.08);
                }
                else if (liters > 25)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }

                Console.WriteLine($"{totalPrice:f2} lv.");
            }
        }
    }
}