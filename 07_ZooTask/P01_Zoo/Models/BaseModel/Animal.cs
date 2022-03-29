namespace P01_Zoo.Models.BaseModel
{
    using System;

    using P01_Zoo.Constants.Messages;

    public abstract class Animal
    {
        private const int NAME_MIN_LENGHT = 3;
        private const int MIN_AGE_VALUE = 0;

        private string name;
        private int age;

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ErrorMessages.NULL_NAME);
                }

                if (value.Length < NAME_MIN_LENGHT)
                {
                    string errorMessage = 
                        string.Format(ErrorMessages.NAME_LENGHT, NAME_MIN_LENGHT);

                    throw new ArgumentException(errorMessage);
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
                if (value <= MIN_AGE_VALUE)
                {
                    throw new ArgumentException(ErrorMessages.INVALID_AGE);
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Name: {this.Name} Age: {this.Age}";
        }
    }
}
