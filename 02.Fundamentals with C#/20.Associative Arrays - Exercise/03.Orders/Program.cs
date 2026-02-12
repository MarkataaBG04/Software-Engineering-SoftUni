
namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] commandArgs = input.Split();
                string name = commandArgs[0];
                decimal price = decimal.Parse(commandArgs[1]);
                decimal quanity = decimal.Parse(commandArgs[2]);

                Product newProduct = new Product(name, price, quanity);

                if (!products.ContainsKey(newProduct.Name))
                {
                    products.Add(newProduct.Name, newProduct);
                }
                else
                {
                    products[newProduct.Name].Upgrade(newProduct.Price, newProduct.Quantity);
                }

            }

            foreach (KeyValuePair<string, Product> productPair in products)
            {
                Console.WriteLine($"{productPair.Value}");
            }

       
        }
    }

    class Product 
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity += quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public void Upgrade(decimal newPrice, decimal newQuantity)
        {
            Price = newPrice;
            Quantity += newQuantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:F2}";
        }
    }
}
