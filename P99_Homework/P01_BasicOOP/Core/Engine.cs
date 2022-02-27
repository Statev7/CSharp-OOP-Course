namespace P01_BasicOOP.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P01_BasicOOP.Models;

    public class Engine
    {
        public void Run()
        {
            // {typeOfVehicle} {model} {color} {horsepower}
            HashSet<Vehicle> vehicles = new HashSet<Vehicle>();

            while (true)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (arguments[0] == "End")
                {
                    break;
                }

                string type = arguments[0];
                type = type[0].ToString().ToUpper() + type.Substring(1);

                string model = arguments[1];
                string color = arguments[2];
                int horsePower = int.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            while (true)
            {
                string argument = Console.ReadLine();

                if (argument == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = vehicles.SingleOrDefault(v => v.Model == argument);
                Console.WriteLine(vehicle);
            }

            // "{typeOfVehicles} have average horsepower of {averageHorsepower}."

            double carsAvgHorsePower = vehicles.Where(v => v.Type == "Car").Average(v => v.HoursePower);
            double trucksAvgHorsePower = vehicles.Where(v => v.Type == "Truck").Average(v => v.HoursePower);

            string carResult = $"Cars have average horsepower of {carsAvgHorsePower:F2}.";
            string truckResult = $"Trucks have average horsepower of {trucksAvgHorsePower:F2}.";

            Console.WriteLine(carResult);
            Console.WriteLine(truckResult);
        }
    }
}
