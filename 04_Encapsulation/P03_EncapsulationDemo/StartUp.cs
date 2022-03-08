namespace P03_EncapsulationDemo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {

            Cat cat = new Cat("Pesho", 12);
            Console.WriteLine(cat.Name);

        }
    }
}
