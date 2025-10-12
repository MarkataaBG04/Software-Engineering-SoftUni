namespace _07.Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int smallerNum = int.MaxValue;

            while (command != "Stop")
            {
                int num = int.Parse(command);

                if (num < smallerNum)
                {
                    smallerNum = num;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(smallerNum);
        }
    }
}