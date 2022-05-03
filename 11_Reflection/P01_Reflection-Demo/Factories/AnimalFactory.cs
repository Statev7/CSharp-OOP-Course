namespace P01_Reflection_Demo.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P01_Reflection_Demo.Models.Animals;

    public class AnimalFactory
    {
        public Animal Create(string input)
        {
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string typeAsString = tokens[0].ToLower(); 
            string name = tokens[1];
            int age = int.Parse(tokens[2]);

            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes().FirstOrDefault(type => type.Name.ToLower() == typeAsString);

            bool isNull = type == null;
            if (isNull)
            {
                throw new NullReferenceException("Invalid type name!");
            }

            object[] arguments = new object[] { name, age };
            Animal animal = (Animal)Activator.CreateInstance(type, arguments);

            return animal;
        }
    }
}
