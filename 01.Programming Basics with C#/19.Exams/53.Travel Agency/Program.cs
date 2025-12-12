namespace _53.Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string town = Console.ReadLine();
           string packetOption = Console.ReadLine();
           string vipCard = Console.ReadLine();
           int daysToStay = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (daysToStay < 1)
            {
                Console.WriteLine($"Days must be positive number!");
                return;
            }


            if (town == "Bansko" || town == "Borovets")
            {
                if (packetOption == "withEquipment")
                {
                    if (vipCard == "yes")
                    {
                        if (daysToStay > 7)
                        {
                            daysToStay -= 1;
                            totalSum = daysToStay * 100;
                            totalSum -= totalSum * 0.10;
                        }
                        else
                        {
                            totalSum = daysToStay * 100;
                            totalSum -= totalSum * 0.10;
                        }
                    }
                    else if (vipCard == "no")
                    {
                        totalSum = daysToStay * 100;
                    }
                }
                else if (packetOption == "noEquipment")
                {
                    if (vipCard == "yes")
                    {
                        if (daysToStay > 7)
                        {
                            daysToStay -= 1;
                            totalSum = daysToStay * 80;
                            totalSum -= totalSum * 0.05;
                        }
                        else
                        {
                            totalSum = daysToStay * 80;
                            totalSum -= totalSum * 0.05;
                        }
                    }
                    else if (vipCard == "no")
                    {
                        totalSum = daysToStay * 80;
                    }
                }
                else 
                {
                    Console.WriteLine($"Invalid input!");
                    return;
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (packetOption == "withBreakfast")
                {
                    if (vipCard == "yes")
                    {
                        if (daysToStay > 7)
                        {
                            daysToStay -= 1;
                            totalSum = daysToStay * 130;
                            totalSum -= totalSum * 0.12;
                        }
                        else
                        {
                            totalSum = daysToStay * 130;
                            totalSum -= totalSum * 0.12;
                        }
                    }
                    else if (vipCard == "no")
                    {
                        totalSum = daysToStay * 130;
                    }
                }
                else if (packetOption == "noBreakfast")
                {
                    if (vipCard == "yes")
                    {
                        if (daysToStay > 7)
                        {
                            daysToStay -= 1;
                            totalSum = daysToStay * 100;
                            totalSum -= totalSum * 0.07;
                        }
                        else
                        {
                            totalSum = daysToStay * 100;
                            totalSum -= totalSum * 0.07;
                        }
                    }
                    else if (vipCard == "no")
                    {
                        totalSum = daysToStay * 100;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
                return;
            }


            Console.WriteLine($"The price is {totalSum:f2}lv! Have a nice time!");
        }
    }
}
