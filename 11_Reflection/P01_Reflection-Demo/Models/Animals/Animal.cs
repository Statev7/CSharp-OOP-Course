namespace P01_Reflection_Demo.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.Age}";
        }
    }
}
