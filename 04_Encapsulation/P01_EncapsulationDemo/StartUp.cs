namespace P01_EncapsulationDemo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {

            Cat cat = new Cat("Pesho", 2);

            Console.WriteLine(cat.Name);

           
        }
    }
}
