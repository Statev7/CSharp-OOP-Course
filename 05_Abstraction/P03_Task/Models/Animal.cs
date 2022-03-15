namespace P03_Task.Models
{
    using System;

    public abstract class Animal
    {
        public string name;
        internal int age;

        public Animal(string name, int age)
        {

        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.Age = value;   
            }
        }

        public abstract string MakeSound();
    }
}
