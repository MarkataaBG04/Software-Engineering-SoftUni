using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            for (int i = 1; i <= nTabs; i++)
            {
                string tabName = Console.ReadLine();
                if (tabName == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (tabName == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (tabName == "Reddit")
                {
                    salary = salary - 50;
                }

                if (salary <=0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    return;
                }
                else
                {
                    continue;
                }
            }

                Console.WriteLine($"{salary}");
            
        }
    }
}