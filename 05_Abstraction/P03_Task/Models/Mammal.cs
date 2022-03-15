namespace P03_Task.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, int age, string breed) 
            : base(name, age)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public abstract string Eat();
    }
}
