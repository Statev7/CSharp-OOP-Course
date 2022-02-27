namespace P03_RawData2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P03_RawData2.Models;

    public class Engine
    {
        public void Run()
        {
            // "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}
            // {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age}
            // {tire4Pressure} {tire4Age}"

            var cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.TrimEntries)
                    .ToArray();

                string model = arguments[0];
                int engineSpeed = int.Parse(arguments[1]);
                int enginePower = int.Parse(arguments[2]);
                int cargoWeight = int.Parse(arguments[3]);
                string cargoType = arguments[4];

                CarEngine engine = new CarEngine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4];

                int index = 0;
                for (int j = 5; j < arguments.Length; j+=2)
                {
                    double pressure = double.Parse(arguments[j]);
                    int age = int.Parse(arguments[j + 1]);

                    Tire tire = new Tire(age, pressure);
                    tires[index] = tire;
                    index++;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string filter = Console.ReadLine();

            var list = new List<Car>();
            if (filter == "fragile")
            {
                list = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                list = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
            }

            foreach (var car in list)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
