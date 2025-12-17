namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double balance = 0;


            while (command != "Start") 
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    balance += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                    command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (balance >= 2.0)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        
                    }
                }
                else if (product == "Water")
                {
                    if (balance >= 0.7)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        
                    }
                }
                else if (product == "Crisps")
                {
                    if (balance >= 1.5)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        
                    }
                }
                else if (product == "Soda")
                {
                    if (balance >= 0.8)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        
                    }
                }
                else if (product == "Coke")
                {
                    if (balance >= 1.0)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                }
                    product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
