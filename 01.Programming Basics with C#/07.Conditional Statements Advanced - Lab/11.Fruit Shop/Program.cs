namespace _11.Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quanity = double.Parse(Console.ReadLine());

            double price = 0;
            bool isValid = true;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        price = quanity * 2.5;
                    }
                    else if (fruit == "apple")
                    {
                        price = quanity * 1.20;
                    }
                    else if (fruit == "orange")
                    {
                        price = quanity * 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = quanity * 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = quanity * 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = quanity * 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        price = quanity * 3.85;
                    }
                    else
                    {
                        isValid = false;
                    }

                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        price = quanity * 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        price = quanity * 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = quanity * 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = quanity * 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = quanity * 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = quanity * 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        price = quanity * 4.20;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine($"error");
            }
        }
    }
}