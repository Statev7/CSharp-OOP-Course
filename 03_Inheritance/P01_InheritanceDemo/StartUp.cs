namespace P01_InheritanceDemo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Cat cat = new Cat("Pesho", 7, "idk");
            Dog dog = new Dog("Vankata", 12);

            cat.MakeSound();
            dog.MakeSound();

            Console.WriteLine(cat);
            Console.WriteLine(dog);
        }
    }
}
