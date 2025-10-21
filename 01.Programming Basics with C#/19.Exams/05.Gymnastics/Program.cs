namespace _05.Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string country = Console.ReadLine();
            string device = Console.ReadLine();

            double points = 0;


            if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    points = 9.100 + 9.400;
                }
                else if (device == "hoop")
                {
                    points = 9.300 + 9.800;
                }
                else if(device == "rope")
                {
                    points = 9.600 + 9.000;
                }
            }
            else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    points = 9.600 + 9.400;
                }
                else if (device == "hoop")
                {
                    points = 9.550 + 9.750;
                }
                else if (device == "rope")
                {
                    points = 9.500 + 9.400;
                }
            }
            else if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    points = 9.200 + 9.500;
                }
                else if (device == "hoop")
                {
                    points = 9.450 + 9.350;
                }
                else if (device == "rope")
                {
                    points = 9.700 + 9.150;
                }
            }


            double neededPoint = 20 - points;

            Console.WriteLine($"The team of {country} get {points:f3} on {device}.");
            Console.WriteLine($"{neededPoint/20*100:f2}%");
        }
    }
}