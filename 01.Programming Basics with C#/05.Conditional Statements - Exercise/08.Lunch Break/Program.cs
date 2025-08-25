namespace _08.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //По време на обедната почивка искате да изгледате епизод от своя любим сериал.Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно време да изгледате епизода. По време на почивката отделяте време за обяд и време за отдих. Времето за обяд ще бъде 1 / 8 от времето за почивка, а времето за отдих ще бъде 1 / 4 от времето за почивка.

            //От конзолата се четат 3 реда:

            //1.Име на сериал – текст

            //2.Продължителност на епизод – цяло число в диапазона[10… 90]

            //3.Продължителност на почивката – цяло число в диапазона[10… 120

            string seriesName = Console.ReadLine();

            int episodeDuration = int.Parse(Console.ReadLine());

            int brakeTime = int.Parse(Console.ReadLine());

            double relaxTime = brakeTime / 4.0;

            double lunchTime = brakeTime / 8.0;

            double totalBrakeTime = brakeTime - relaxTime - lunchTime;

            if (totalBrakeTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(totalBrakeTime - episodeDuration)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - totalBrakeTime)} more minutes.");
            }
        }
    }
}