namespace _03.Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете градуси по скалата на Целзий(°C) и ги преобразува до градуси по скалата на Фаренхайт(°F).
            //Потърсете в Интернет подходяща формула, с която да извършите изчисленията.
            //Форматирате изхода до втория знак след десетичната запетая. 

            double tempCelsius = double.Parse(Console.ReadLine());

            double tempFahrenheit = (tempCelsius * 9 / 5) + 32;

            Console.WriteLine($"{tempFahrenheit:F2}");
        }
    }
}