namespace _07.Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleCatalog catalog = new VehicleCatalog();
            string input;

            while ((input = Console.ReadLine()) != "end") 
            {
                string[] tokens = input.Split("/");

                switch (tokens[0])
                {
                    case "Car":
                        Car car = new Car()
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = tokens[3],
                        };
                        catalog.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck()
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = tokens[3],
                        };
                        catalog.Trucks.Add(truck);
                        break;
                    default:
                        break;
                }
            }

            catalog.Cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();

            Console.WriteLine($"Cars:");
            foreach (Car car in catalog.Cars)
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine($"Trucks:");
            foreach (Truck truck in catalog.Trucks)
            {

                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }
    class VehicleCatalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public VehicleCatalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>(); // може и да не го ползваш още
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public  string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

}
