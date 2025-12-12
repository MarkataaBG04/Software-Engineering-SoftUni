namespace _47._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int seriesCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= seriesCount; i++) 
            {
                string seriesName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (seriesName == "Thrones")
                {
                    price -= price * 0.50;
                    
                }
                else if (seriesName == "Lucifer")
                {
                    price -= price * 0.40;
                   
                }
                else if (seriesName == "Protector")
                {
                    price -= price * 0.30;
                    
                }
                else if (seriesName == "TotalDrama")
                {
                    price -= price * 0.20;
                   
                }
                else if (seriesName == "Area")
                {
                    price -= price * 0.10;
                   
                }
               
                    budjet -= price;
                

            }

            if (budjet >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budjet:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budjet):F2} lv. more to buy the series!");
            }
        }
    }
}
