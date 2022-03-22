namespace P01_PolymorphismDemo
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P01_PolymorphismDemo.Models;
    using P01_PolymorphismDemo.Models.BaseModel;
    using P01_PolymorphismDemo.Models.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            // {type} {name} {age}
            string[] arguments = Console.ReadLine().Split(' ');
            string typeAsString = arguments[0];
            string name = arguments[1];
            int age = int.Parse(arguments[2]);

            Type type = Assembly.GetCallingAssembly()
                .GetTypes()
                .SingleOrDefault(t => t.Name.ToLower() == typeAsString.ToLower());

            object[] arg = new object[] { name, age };
            Animal animal = (Animal)Activator.CreateInstance(type, arg);
            Console.WriteLine(animal);


            //try
            //{
            //    switch (type)
            //    {
            //        case "Cat": animal = new Cat(name, age); break;
            //        case "Dog":
            //            animal = new Dog(name, age);
            //            break;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(animal);
        }
    }
}
