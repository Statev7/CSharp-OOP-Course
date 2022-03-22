namespace P03_PolymorphismDemo.Models.BaseModel
{
    public abstract class Animal
    {
        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}, Type: {this.GetType().Name}";
        }
    }
}
