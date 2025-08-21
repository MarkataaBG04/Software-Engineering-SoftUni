namespace _07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ресторант отваря врати и предлага няколко менюта на преференциални цени: 
            //    •	Пилешко меню –  10.35 лв.
            //    •	Меню с риба – 12.40 лв.
            //    •	Вегетарианско меню  – 8.15 лв.
            //            Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
            //            Групата ще си поръча и десерт, чиято цена е равна на 20 % от общата сметка(без доставката). 
            //            Цената на доставка е 2.50 лв и се начислява най - накрая.


            //От конзолата се четат 3 реда:
            //    •	Брой пилешки менюта – цяло число в интервала[0 … 99]
            //    •	Брой менюта с риба – цяло число в интервала[0 … 99]
            //    •	Брой вегетариански менюта – цяло число в интервала[0 … 99]
            //Изход
            //Да се отпечата на конзолата един ред:  "{цена на поръчката}"

            int chickenMenusCount = int.Parse(Console.ReadLine());
            int fishMenusCount = int.Parse(Console.ReadLine());
            int vegeterianMenusCount = int.Parse(Console.ReadLine());

            double totalSum = (chickenMenusCount * 10.35) + (fishMenusCount * 12.40) + (vegeterianMenusCount * 8.15);

            double desert = totalSum * 0.20;

            totalSum = totalSum + desert + 2.5;

            Console.WriteLine(totalSum);
        }
    }
}