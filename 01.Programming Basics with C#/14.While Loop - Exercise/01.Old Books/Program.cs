namespace _01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();

            int counter = 0;

            string command = Console.ReadLine();

            while (command != "No More Books")
            {
                
                if (command != favBook)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }

                command = Console.ReadLine();
            }

            if (command == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}