namespace P01_PolymorphismDemo.Models.BaseModel
{
    using System;

    using P01_PolymorphismDemo.Models.Contracts;

    public abstract class Animal : IAnimal
    {
        private const string INVALID_NAME_ERROR_MESSAGE = "{0} is not a valid name!";
        private const int NAME_LENGHT_MIN_VALUE = 3;

        private string name;

        protected Animal(string name, int age)
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
                if (value.Length < NAME_LENGHT_MIN_VALUE)
                {
                    string errorMessage = 
                        string.Format(INVALID_NAME_ERROR_MESSAGE, value);

                    throw new ArgumentException(errorMessage);
                }

                this.name = value;
            }
        }

        public int Age { get; private set; }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"Name {this.Name}, Age:{this.Age}, Type: {this.GetType().Name}";
        }
    }
}
