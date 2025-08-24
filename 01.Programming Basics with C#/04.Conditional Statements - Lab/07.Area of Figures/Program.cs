using System.Drawing;

namespace _07.Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).
            //На първия ред на входа се чете вида на фигурата(текст със следните възможности: square, rectangle, circle или triangle). 
            //•	Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му
            //•	Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му
            //•	Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга

            //•	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея

            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideLenght = double.Parse(Console.ReadLine());

                double areaSquare = Math.Pow(sideLenght, 2);
                Console.WriteLine($"{areaSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double rectangleArea = sideA * sideB;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double circleArea = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figure == "triangle")
            {
                double sideLenght = double.Parse(Console.ReadLine());
                double sideHight = double.Parse(Console.ReadLine());

                double triangleArea = (sideHight * sideLenght) / 2;

                Console.WriteLine($"{triangleArea:f3}");
            }

        }
    }
}