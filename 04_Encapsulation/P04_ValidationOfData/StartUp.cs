namespace P04_ValidationOfData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Person person = new Person("Pesho", "Peshev", -5, 650);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
