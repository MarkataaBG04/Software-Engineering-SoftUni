namespace _01.Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());


            double price = 0;

            if (people >= 1 && people <= 4)
            {
                budjet = budjet - (budjet * 0.75);
            }
            else if (people >= 5 && people <= 9)
            {
                budjet = budjet - (budjet * 0.60);
            }
            else if (people >= 10 && people <= 24)
            {
                budjet = budjet - (budjet * 0.50);
            }
            else if (people >= 25 && people <= 49)
            {
                budjet = budjet - (budjet * 0.40);
            }
            else if (people >= 50)
            {
                budjet = budjet - (budjet * 0.25);
            }

            if (category == "VIP")
            {
                if (budjet >= people * 499.99)
                {
                    price = people * 499.99;
                    Console.WriteLine($"Yes! You have {budjet - price:f2} leva left.");
                }
                else
                {
                    price = people * 499.99;
                    Console.WriteLine($"Not enough money! You need {price - budjet:f2} leva.");
                }
            }
            else if (category == "Normal")
            {
                if (budjet >= people * 249.99)
                {
                    price = people * 249.99;
                    Console.WriteLine($"Yes! You have {budjet - price:f2} leva left.");
                }
                else
                {
                    price = people * 249.99;
                    Console.WriteLine($"Not enough money! You need {price - budjet:f2} leva.");
                }
            }
        }
    }
}