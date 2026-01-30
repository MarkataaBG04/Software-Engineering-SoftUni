namespace _06.Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                int hp = int.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hp);
                catalogue.Add(vehicle);
            }


            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = input;

                Vehicle foundVehicle = catalogue.FirstOrDefault(vehicle => vehicle.Model == vehicleModel);

                if (foundVehicle != null) 
                {
                    Console.WriteLine(foundVehicle);
                }

            }

            double averageHp = catalogue
                .Where(vehicle => vehicle.Type == "Car")
                .Select(vehicle => vehicle.HorsePower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHp:f2}.");

            averageHp = catalogue
                .Where(vehicle => vehicle.Type == "Truck")
                .Select(vehicle => vehicle.HorsePower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Trucks have average horsepower of: {averageHp:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            if (type == "car")
            {
                Type = "Car";
            }
            else if (type == "truck")
            {
                Type = "Truck";
            }

            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; }
        public string Model { get; }
        public string Color { get; }
        public int HorsePower { get; }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HorsePower}";

        }
    }
}
