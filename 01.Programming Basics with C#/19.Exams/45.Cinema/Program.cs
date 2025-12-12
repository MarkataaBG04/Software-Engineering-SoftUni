using System;

namespace _45.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityKino = int.Parse(Console.ReadLine());
            int income = 0;

            string command = Console.ReadLine();

            while (command != "Movie time!")
            {
                int peopleEntering = int.Parse(command);

                // Ако групата е по-голяма от останалите места → киното е пълно
                if (peopleEntering > capacityKino)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {income} lv.");
                    return;
                }

                // Намаляваме свободните места
                capacityKino -= peopleEntering;

                // Цена: 5 лв на човек
                // Ако броят се дели на 3 → -5 лв отстъпка
                if (peopleEntering % 3 == 0)
                {
                    income += peopleEntering * 5 - 5;
                }
                else
                {
                    income += peopleEntering * 5;
                }

                command = Console.ReadLine();
            }

            // Ако сме получили "Movie time!"
            Console.WriteLine($"There are {capacityKino} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
