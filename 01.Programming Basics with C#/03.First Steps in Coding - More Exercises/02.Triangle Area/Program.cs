namespace _02.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата страна и височина на триъгълник и пресмята неговото лице.
            //Използвайте формулата за лице на триъгълник: area = a * h / 2.
            //Форматирате изхода до втория знак след десетичната запетая.

            double sideA = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = sideA * hight / 2;

            Console.WriteLine($"{area:f2}");

        }
    }
}