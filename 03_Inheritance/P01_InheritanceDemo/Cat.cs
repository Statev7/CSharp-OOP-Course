namespace P01_InheritanceDemo
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string breed)
            :base(name, age)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override void MakeSound()
        {
            System.Console.WriteLine("Meowww...");
        }

        public override string ToString()
        {
            return base.ToString() + $" {this.Breed}";
        }
    }
}
