namespace P04_Animals
{
    using System;

    using P04_Animals.Models;
    using P04_Animals.Models.BaseModel;

    public class StartUp
    {
        public static void Main()
        {
            Animal cat = new Cat("Pesho", "Idk");
            Animal dog = new Dog("Pepo", "idk2");
            //Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
