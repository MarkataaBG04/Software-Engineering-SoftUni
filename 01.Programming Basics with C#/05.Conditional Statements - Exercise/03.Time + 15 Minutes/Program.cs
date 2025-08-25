namespace _03.Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час и минути от 24 - часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути.
            //Резултатът да се отпечата във формат часове: минути.
            //Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59.
            //Часовете се изписват с една или две цифри.Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;

            if (newMinutes > 59)
            {
                newMinutes = newMinutes % 60;
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
            }

            if (newMinutes < 10 )
            {
                Console.WriteLine($"{hours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{newMinutes}");
            }

        }
    }
}