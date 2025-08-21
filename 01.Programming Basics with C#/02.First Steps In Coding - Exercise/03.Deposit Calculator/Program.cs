namespace _03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява каква сума ще получите в края на депозитния период при определен лихвен процент.
            //Използвайте следната формула: сума = депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            
            //От конзолата се четат 3 реда:
            //1.Депозирана сума – реално число в интервала[100.00 … 10000.00]
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00]


            double depositSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interestTrial = double.Parse(Console.ReadLine());

            double sum = depositSum + period * ((depositSum * interestTrial / 100) / 12);

            Console.WriteLine(sum);


        }
    }
}