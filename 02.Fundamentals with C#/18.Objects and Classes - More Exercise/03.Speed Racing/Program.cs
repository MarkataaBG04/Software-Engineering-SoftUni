namespace _03.Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int carsNumber = int.Parse(Console.ReadLine());



            for (int i = 1; i <= carsNumber; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string model = arguments[0];
                double fuelAmount = double.Parse(arguments[1]);
                double fuelConsumation = double.Parse(arguments[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumation);

                cars.Add(newCar);
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string model = arguments[1];

                double amountOfKm = double.Parse(arguments[2]);

                Car currentCar = cars.FirstOrDefault(c => c.Model == model);

                if (currentCar != null)
                {
                    currentCar.Drive(amountOfKm);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
    class Car 
    {
        public void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumationPerKilometer;

            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumationPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumationPerKilometer = fuelConsumationPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumationPerKilometer { get; set; }

        public double TraveledDistance { get; set; }
    }
}
