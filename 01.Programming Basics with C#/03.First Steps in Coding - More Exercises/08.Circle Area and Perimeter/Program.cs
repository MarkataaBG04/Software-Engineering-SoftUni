namespace _08.Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, като форматирате изхода в следния вид: "calculated area"
//"calculated parameter".Форматирайте изходните данни до втория знак след десетичната запетая.

            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(r, 2); //π × r2

            double circlePerimeter = 2 * Math.PI * r;  //p = 2πr

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{circlePerimeter:f2}");
        }
    }
}