namespace P02_ValidationOfData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ");

                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                decimal salary = decimal.Parse(arguments[3]);


                try
                {
                    Person person = new Person(firstName, lastName, age, salary);
                    Console.WriteLine(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            
        }
    }
}
