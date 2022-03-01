namespace P02_Person
{
    using System;

    using P02_Person.Models;

    public class StartUp
    {
        public static void Main()
        {
            Child child = new Child("Ivan", 12);
            Console.WriteLine(child);

            try
            {
                Person person = new Person("Pesho", -3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
