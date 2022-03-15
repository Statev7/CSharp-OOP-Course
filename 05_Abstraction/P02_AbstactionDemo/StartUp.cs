namespace P02_AbstactionDemo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //Cat cat = new Cat("Pesho", 7);
            //Dog dog = new Dog("Sharo", 8);

            //Console.WriteLine(cat.MakeSound());
            //Console.WriteLine(dog.MakeSound());

            StaticDemo.IsNull();

            //StaticDemo staticDemo = new StaticDemo();

            IAnimal animal = new Cat("Pesho", 12);

            
        }
    }
}
