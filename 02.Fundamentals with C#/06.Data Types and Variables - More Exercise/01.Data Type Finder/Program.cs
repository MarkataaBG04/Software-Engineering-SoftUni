namespace _01.Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (int.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (double.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (bool.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else if (char.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();
            }
        }
    }
}
