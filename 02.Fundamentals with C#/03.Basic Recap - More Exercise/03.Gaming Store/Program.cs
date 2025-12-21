using System;

namespace _03.Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double totalSpent = 0;

            while (game != "Game Time")
            {
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }


                if (game == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else
                {
                    Console.WriteLine($"Not Found");
                }

               
                    game = Console.ReadLine();
             
            }

                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            
        }
    }
}
