namespace P02_RawData.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P02_RawData.Models;

    public class Engine
    {
        public void Run()
        {
            var cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"

                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = arguments[0];
                int engineSpeed = int.Parse(arguments[1]);
                int enginePower = int.Parse(arguments[2]);
                int cargoWeight = int.Parse(arguments[3]);
                string cargoType = arguments[4];

                CarEngine engine = new CarEngine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }

            // fragile and flamable

            string filter = Console.ReadLine();
            List<Car> list = new List<Car>();

            if (filter == "fragile")
            {
                list = cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000).ToList();
            }
            else
            {
                list = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
            }

            foreach (var car in list)
            {
                Console.WriteLine(car);
            }
        }
    }
}
