namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalSum = 0;


            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                totalSum = price * count;

                if (count >= 30)
                {
                    totalSum -= totalSum * 0.15;
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                totalSum = price * count;

                if (count >= 100)
                {
                    double discount = 10 * price;
                    totalSum = totalSum - discount;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                totalSum = price * count;
                if (count >= 10 && count <= 20)
                {
                    totalSum -= totalSum * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalSum:f2}");

        }
    }
}
