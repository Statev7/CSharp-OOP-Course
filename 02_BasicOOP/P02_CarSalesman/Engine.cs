namespace P02_CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            int n = int.Parse(System.Console.ReadLine());
            var list = new List<CarEngine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                CarEngine engine = null;
                string model = arg[0];
                double power = double.Parse(arg[1]);
                string efficiency = string.Empty;

                if (arg.Length == 2)
                {
                    engine = new CarEngine(model, power);
                }
                else if (arg.Length == 3)
                {
                    double displacement; // 5

                    if (double.TryParse(arg[2], out displacement))
                    {
                        engine = new CarEngine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = arg[2];
                        engine = new CarEngine(model, power, efficiency);
                    }
                }
                else
                {
                    double displacement = double.Parse(arg[2]);
                    efficiency = arg[3];
                    engine = new CarEngine(model, power, displacement, efficiency);
                }

                list.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] arg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //"{model} {engine}" 
                //"{model} {engine} {weight}" 
                //"{model} {engine} {color}" 
                //"{model} {engine} {weight} {color}" 
                // 0 1 2 3

                Car car = null;
                string model = arg[0];
                CarEngine engine = list.SingleOrDefault(e => e.Model == arg[1]);

                if (arg.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (arg.Length == 3)
                {
                    double weight;

                    if (double.TryParse(arg[2], out weight))
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = arg[2];
                        car = new Car(model, engine, color);
                    }
                }
                else
                {
                    double weight = double.Parse(arg[2]);
                    string color = arg[3];
                    car = new Car(model, engine, weight, color);
                }

                cars.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
