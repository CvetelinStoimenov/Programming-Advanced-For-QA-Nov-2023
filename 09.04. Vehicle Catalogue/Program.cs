using System.Diagnostics;
using System.Reflection;

namespace _09._04._Vehicle_Catalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    { 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        { 
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string[] data = command.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Car")
                {
                    Car currentCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = int.Parse(data[3])
                    };

                    catalog.Cars.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = int.Parse(data[3])
                    };

                    catalog.Trucks.Add(currentTruck);
                };

                command = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0) 
            {
                List<Car> orderCars = catalog.Cars
                    .OrderBy(car => car.Brand)
                    .ToList();

                Console.WriteLine("Cars:");
                foreach (Car car in orderCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Any())
            {
                List<Truck> orderTrucks = catalog.Trucks
                    .OrderBy(truck => truck.Brand)
                    .ToList();

                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}