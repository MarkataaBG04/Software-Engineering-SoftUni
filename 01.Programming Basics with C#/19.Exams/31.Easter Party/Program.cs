namespace _31.Еaster_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double priceForOnePerson = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            double totalSum = 0;

            if (guests >= 10 && guests <= 15)
            {
                priceForOnePerson = priceForOnePerson * 0.85;
            }
            else if (guests >= 15 && guests <= 20) 
            {
                priceForOnePerson = priceForOnePerson * 0.80;
            }
            else if (guests > 20)
            {
                priceForOnePerson = priceForOnePerson * 0.75;
            }

            totalSum = priceForOnePerson * guests;

            totalSum = totalSum + (budjet * 0.1);

            if (budjet >= totalSum)
            {
                Console.WriteLine($"It is party time! {budjet - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalSum-budjet:f2} leva needed.");
            }

        }
    }
}