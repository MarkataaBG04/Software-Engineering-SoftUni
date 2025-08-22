namespace _09.Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaPainted = double.Parse(Console.ReadLine());

            double discount;

            double totalSum = areaPainted * 7.61;

            discount = totalSum * 0.18;

            Console.WriteLine($"The final price is: {totalSum - discount}");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}