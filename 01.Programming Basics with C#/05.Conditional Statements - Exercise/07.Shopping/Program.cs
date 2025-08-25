﻿namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Петър иска да купи N видеокарти, M процесора и P на брой рам памет.Ако броя на видеокартите е по-голям от този на процесорите получава 15 % отстъпка от крайната сметка.
            //    Важат следните цени:

            //    · Видеокарта – 250 лв./ бр.

            //    · Процесор – 35 % от цената на закупените видеокарти/ бр.

            //    · Рам памет – 10 % от цената на закупените видеокарти/ бр.

            //    Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.

            //                Вход

            //            Входът се състои от четири реда:

            //            1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            //            2.Броят видеокарти - цяло число в интервала[0…100]
            //            3.Броят процесори - цяло число в интервала[0…100]
            //            4.Броят рам памет -цяло число в интервала[0…100]


            double budjet = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = gpuCount * 250;

            double cpuPrice = cpuCount * gpuPrice * 0.35;

            double ramPrice = ramCount * gpuPrice * 0.10;


            double totalPrice = gpuPrice + cpuPrice + ramPrice;


            if (gpuCount > cpuCount)
            {
                totalPrice = totalPrice * 0.85;
            }

            if (budjet >= totalPrice)
            {
                Console.WriteLine($"You have {budjet - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budjet - totalPrice):f2} leva more!");
            }
        }
    }
}