namespace P01_Zoo.Core
{
    using System;

    using P01_Zoo.Core.Contracts;
    using P01_Zoo.Models;
    using P01_Zoo.Models.BaseModel;
    using P01_Zoo.Models.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            IZoo zoo = new Zoo();

            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Animal animal = CreateAnimal();
                    zoo.Add(animal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            while (true)
            {
                string[] arguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                if (command == "End")
                {
                    break;
                }

                string animalTypeAsString = arguments[1].ToLower();
                string message = string.Empty;

                try
                {
                    switch (command)
                    {
                        case "Remove": 
                            message = zoo.Remove(animalTypeAsString, arguments[2]);
                            break;
                        case "Report":
                            message = zoo.Report(animalTypeAsString, int.Parse(arguments[2]));
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (message != string.Empty)
                {
                    Console.WriteLine(message);
                }
            }
        }

        private static Animal CreateAnimal()
        {
            Animal animal = null;

            string[] arguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string typeAsString = arguments[0].ToLower();
            string name = arguments[1];
            int age = int.Parse(arguments[2]);

            switch (typeAsString)
            {
                case "cat": animal = new Cat(name, age); break;
                case "dog": animal = new Dog(name, age); break;
            }

            return animal;
        }
    }
}
