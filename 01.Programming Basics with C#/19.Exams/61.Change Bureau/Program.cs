namespace _61.Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineeseYoana = double.Parse(Console.ReadLine());
            double commisionPercent = double.Parse(Console.ReadLine());

            double bitcoinChangeEuro = (bitcoins * 1168) / 1.95;
            double chineeseYoanaChangeEuro = ((chineeseYoana * 0.15) * 1.76) / 1.95;
            double sumInEuroWithCommision = bitcoinChangeEuro + chineeseYoanaChangeEuro;
            sumInEuroWithCommision = sumInEuroWithCommision - (sumInEuroWithCommision * commisionPercent / 100.0);

            Console.WriteLine($"{sumInEuroWithCommision:F2}");
        }
    }
}
