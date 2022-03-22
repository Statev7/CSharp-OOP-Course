namespace P03_PolymorphismDemo
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P03_PolymorphismDemo.Models.BaseModel;

    public class StartUp
    {
        public static void Main()
        {
            // {Type} {Name} {Age}

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
        }
    }
}
