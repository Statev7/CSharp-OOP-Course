namespace P02_Reflection_Demo
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P02_Reflection_Demo.Factories;
    using P02_Reflection_Demo.Models.Animals;
    using P02_Reflection_Demo.Models.People;

    public class StartUp
    {
        public static void Main()
        {
            // Type name age

            AnimalFactory factory = new AnimalFactory();

            string input = Console.ReadLine();
            Animal animal = factory.Create(input);
            Console.WriteLine(animal);

           
            //Console.WriteLine(typeof(Person).FullName);
            //Console.WriteLine(person.GetType().Name);
            //Type type = Type.GetType("P02_Reflection_Demo.Models.People.Person");

            //Console.WriteLine(person.FirstName);

            //string propertyName = Console.ReadLine();
            //var property = type.GetProperty(propertyName);

            //bool isNull = property == null;
            //if (isNull)
            //{
            //    return;
            //}

            //property.SetValue(person, "Pesho");
            //Console.WriteLine($"{person.FirstName} {person.LastName}");

            //Console.WriteLine(fileds.Count());

            //foreach (var fild in fileds)
            //{
            //    Console.WriteLine(fild.Name);
            //}
        }
    }
}
