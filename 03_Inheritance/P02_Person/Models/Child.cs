namespace P02_Person.Models
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            :base(name, age)
        {

        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.Age = value;
            }
        }

        public override string ToString()
        {
            return $"{base.Name} {this.Age}";
        }
    }
}
