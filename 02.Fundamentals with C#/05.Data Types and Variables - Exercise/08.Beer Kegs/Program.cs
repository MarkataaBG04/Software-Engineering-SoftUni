namespace _08.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            double biggestKeg = double.MinValue;
            string biggestKegModel = "";

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentKegSizes = 0;

                currentKegSizes = Math.PI * Math.Pow(radius, 2) * height;

                if (currentKegSizes > biggestKeg)
                {
                    biggestKeg = currentKegSizes;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
