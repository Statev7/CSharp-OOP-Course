namespace P01_Reflection_Demo
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P01_Reflection_Demo.Factories;
    using P01_Reflection_Demo.Models.Animals;
    using P01_Reflection_Demo.Models.People;

    public class StartUp
    {
        public static void Main()
        {
            //Person person = new Person("Gosho", "Peshev");
            AnimalFactory factory = new AnimalFactory();
            string input = Console.ReadLine();

            try
            {
                factory.Create(input);
            }
            catch (Exception ane)
            {
                Console.WriteLine(ane.Message);
            }
            

            //Type type = person.GetType();
            //Type type1 = typeof(Cat);
            //Type type2 = Type.GetType("P01_Reflection_Demo.Models.Animals.Dog");

            //var properties =  type.GetProperties();
            //Console.WriteLine(properties.Count());

            //foreach (var property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //}

            //string propertyInput = Console.ReadLine();
            //var property = type.GetProperty(propertyInput);

            //bool isNull = property == null;
            //if (isNull)
            //{
            //    throw new ArgumentNullException();
            //}

            //Console.WriteLine(property.GetValue(person));
            //property.SetValue(person, 10);

            //Console.WriteLine(person.Age);

            //var types = Assembly.GetCallingAssembly().GetTypes();
        }
    }
}
