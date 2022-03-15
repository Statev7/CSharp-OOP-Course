namespace P03_Task.Models
{
    public class Cat : Mammal
    {
        public Cat(string name, int age, string breed) 
            : base(name, age, breed)
        {
        }

        public override string Eat()
        {
            return "Meow, meow eattt.";
        }

        public override string MakeSound()
        {
            return "Meoww!";
        }
    }
}
