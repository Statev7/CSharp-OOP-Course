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
                // Първа валидация

                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("Invalid name!");
                }

                // Втора валидация

                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot contain fewer than 3 symbols!");
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
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative.");
                }
            }
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }
    }
}
