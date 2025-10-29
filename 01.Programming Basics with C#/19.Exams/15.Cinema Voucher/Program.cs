namespace _15.Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
              int voucherSun = int.Parse(Console.ReadLine());

              string purchase = Console.ReadLine();

            int ticketMovieCount = 0;
            int othersPurchase = 0;

                
            while (purchase != "End")
            {
                int lenght = purchase.Length;

                char[] symbols = purchase.ToCharArray();

                int symbolsSum = 0;

                if (lenght > 8)
                {

                    if (voucherSun >= symbols[0] + symbols[1])
                    {
                        ticketMovieCount++;
                        symbolsSum = symbols[0] + symbols[1];
                        voucherSun = voucherSun - symbolsSum;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else if (lenght <= 8)
                {
                    if (voucherSun >= symbols[0])
                    {
                        othersPurchase++;
                        symbolsSum = symbols[0];
                        voucherSun = voucherSun - symbolsSum;
                    }
                    else
                    {
                        break;
                    }
                }




                purchase = Console.ReadLine();
            }

            Console.WriteLine(ticketMovieCount);
            Console.WriteLine(othersPurchase);

        }
    }
}