namespace P02_StartUp
{
    using System;

    public class Cat
    {
        // constants
        // fields
        // constructor
        // properties
        // public methods
        // private methods
        private const string INVALID_NAME_ERROR_MESSAGE = "Name cannot be null or empty.";

        private string name;

        public Cat(string name)
        {
            this.Name = name;
        }

        public Cat(string name, byte age)
            :this(name)
        {
            this.Age = age;
        }

        public Cat(string name, byte age, string color)
            :this(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(INVALID_NAME_ERROR_MESSAGE);
                }

                this.name = value;
            }
        }

        public byte Age { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            string result = $"Name: {this.Name}, Age: {this.Age}, Color: {this.Color}";

            return result;
        }
    }
}
