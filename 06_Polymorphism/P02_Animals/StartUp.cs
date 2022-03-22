namespace P02_Animals
{
    using System;

    using P02_Animals.Models;
    using P02_Animals.Models.BaseModel;

    public class StartUp
    {
        public static void Main()
        {
            Animal animal = new Dog("Pesho", "Idk");
            Console.WriteLine(animal.ExplainSelf());
        }
    }
}
