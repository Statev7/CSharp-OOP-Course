namespace P02_Reflection_Demo.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P02_Reflection_Demo.Models.Animals;

    public class AnimalFactory
    {
        public Animal Create(string input)
        {
            string[] tokens = input.Split(' ');

            string typeAsString = tokens[0];
            string name = tokens[1];
            int age = int.Parse(tokens[2]);

            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.Name.ToLower() == typeAsString.ToLower());

            bool isNull = type == null;
            if (isNull)
            {
                throw new NullReferenceException();
            }

            object[] arguments = new object[] { name, age };
            var animal = (Animal)Activator.CreateInstance(type, arguments);

            return animal;
        }
    }
}
