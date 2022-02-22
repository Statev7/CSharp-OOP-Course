namespace P01_SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            var cars = new HashSet<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // "{model}            {fuelAmount}          {fuelConsumptionFor1km}"
                Car car = CreateCar();
                cars.Add(car);
            }

            while (true)
            {
                //"Drive {carModel} {amountOfKm}"
                string[] arg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = arg[0];

                if (command == "End")
                {
                    break;
                }

                string carModel = arg[1];
                double amountOfKm = double.Parse(arg[2]);

                Car car = cars.SingleOrDefault(c => c.Model == carModel);

                try
                {
                    car.Drive(amountOfKm);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Print(cars);
        }

        private static void Print(HashSet<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private static Car CreateCar()
        {
            string[] arg = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

            string model = arg[0];
            double fuel = double.Parse(arg[1]);
            double fuelConsumptionFor1km = double.Parse(arg[2]);

            Car car = new Car(model, fuel, fuelConsumptionFor1km);
            return car;
        }
    }
}
