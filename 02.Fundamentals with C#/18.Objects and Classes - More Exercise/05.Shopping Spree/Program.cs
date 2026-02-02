using System.Xml.Linq;

namespace _05.Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(";");
            foreach (var p in peopleInput)
            {
                string[] parts = p.Split("=");
                string name = parts[0];
                double money = double.Parse(parts[1]);
                Person newPerson = new Person(name, money);
                people.Add(newPerson);
            }

            string[] productsInput = Console.ReadLine().Split(";");
            foreach (var p in productsInput)
            {
                string[] parts = p.Split("=");
                string name = parts[0];
                double cost = double.Parse(parts[1]);
                Product newProduct = new Product(name, cost);
                products.Add(newProduct);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split();
                string personName = parts[0];
                string productName = parts[1];

                Person buyer = people.First(p => p.Name == personName);
                Product item = products.First(p => p.Name == productName);

                buyer.Buy(item);
            }


            foreach (Person person in people) 
            {
                if (person.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(pr => pr.Name))}");
                }
            }
        }
    }



    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }

        public string Name { get; set; }

        public double Money { get; set; }

        public List<Product> Bag { get; set; }
        public void Buy(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                Bag.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

    }

    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public double Cost { get; set; }


    }
}
