namespace P02_StartUp
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //string name = Console.ReadLine();
            //byte age = byte.Parse(Console.ReadLine());


            Cat cat = new Cat("Pesho", 7, "Black");

            Console.WriteLine(cat);
        }
    }
}
