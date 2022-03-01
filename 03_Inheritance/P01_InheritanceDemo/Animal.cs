namespace P01_InheritanceDemo
{
    public class Animal
    {
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
        
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Sound...");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
