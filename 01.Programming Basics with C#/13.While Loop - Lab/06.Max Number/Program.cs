namespace _06.Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int greaterNum = int.MinValue;

            while (command != "Stop")
            {
                int num = int.Parse(command);

                if (num > greaterNum)
                {
                    greaterNum = num;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(greaterNum);
        }
    }
}