namespace P01_Reflection_Demo.Models.People
{
    public class Person
    {
        private int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void Talk()
        {

        }
    }
}
