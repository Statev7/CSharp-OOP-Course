namespace P01_StartUp
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Cat cat = new Cat("P", 12, "black");

                Console.WriteLine(cat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("After...");
        }
    }
}
