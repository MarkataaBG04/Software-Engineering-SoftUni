
namespace _01.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "int":
                int number = int.Parse(Console.ReadLine());
                    DataTypes(number);
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    DataTypes(realNumber);
                    break;
                case "string":
                    string text = Console.ReadLine();
                    DataTypes(text);
                    break;
                default:
                    break;
            }
        }

        static void DataTypes(int number)
        {
            Console.WriteLine($"{number * 2}");
        }

        static void DataTypes(double realNumber)
        {
            Console.WriteLine($"{realNumber * 1.5:F2}");
        }
        static void DataTypes(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
