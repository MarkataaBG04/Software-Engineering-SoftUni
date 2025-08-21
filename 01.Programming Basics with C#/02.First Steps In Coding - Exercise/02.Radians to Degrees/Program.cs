namespace _02.Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете ъгъл в радиани (десетично число) и го преобразува в градуси.
            //Използвайте формулата: градус = радиан * 180 / π.
            //Числото π в C# програми е достъпно чрез Math.PI.

            double radians = double.Parse(Console.ReadLine());

            double angles = (radians * 180) / Math.PI;

            Console.WriteLine(angles);
        }
    }
}