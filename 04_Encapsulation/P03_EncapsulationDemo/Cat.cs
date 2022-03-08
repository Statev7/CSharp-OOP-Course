namespace P03_EncapsulationDemo
{
    using System;

    public class Cat
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                if (value.Length < 3)
                {

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
            private set
            {
                if (value)
                {

                }
            }
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }
    }
}
