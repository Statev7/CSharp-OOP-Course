namespace P01_PolymorphismDemo.Models
{
    using P01_PolymorphismDemo.Models.BaseModel;

    public class Cat : Animal
    {
        public Cat(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Meoww";
        }

        public override string ToString()
        {
            string message = $"{base.ToString()} ,Breed: {this.Breed}";
            return message;
        }
    }
}
