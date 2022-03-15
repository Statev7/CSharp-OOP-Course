namespace P02_AbstactionDemo
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public abstract string MakeSound();
    }
}
